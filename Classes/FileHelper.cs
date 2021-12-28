using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Tanjun
{
    public static class FileHelper
    {
        public static void SerializeModels(string filename, TanjunProject project)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, project);
            stream.Close();
        }

        public static TanjunProject DeserializeModels(string filename)
        {
            IFormatter formatter = new BinaryFormatter();

            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            TanjunProject tjp = (TanjunProject)formatter.Deserialize(stream);
            stream.Close();
            return tjp;
        }

        public static void GenerateCode()
        {
            List<string> code = new List<string>();

            // Define Imports
            foreach (TanjunProject.HeaderData hd in Program.currentProject.imports)
            {
                if (hd.imported)
                {
                    if (hd.type == "Standard Library")
                    {
                        code.Add(String.Format("#include <{0}>", hd.headerName));
                    }
                    else
                    {
                        code.Add(String.Format("#include \"{0}\"", hd.headerName));
                    }
                }
            }

            //Model
            if (Program.currentProject.spriteHasModel)
            {
                code.Add(String.Format("\nconst char* {0} [] = {{ \"{1}\", NULL }};",
                                            Program.currentProject.spriteARCNameList,
                                            Program.currentProject.modelARCName));
            }

            // Class Declarations

            code.Add(String.Format("\nclass {0} : public {1} {{\n\tpublic:",
                                    Program.currentProject.spriteClassName,
                                    Program.currentProject.spriteBaseClassName));

            code.Add("\n\tint onCreate(); " +
                        "\n\tint onExecute();" +
                        "\n\tint onDelete();" +
                        "\n\tint onDraw();");

            // More Model Stuff
            if (Program.currentProject.spriteHasModel)
            {
                code.Add("\n\tvoid updateModelMatrices();");
            }

            if (Program.currentProject.spriteHasAnimation)
            {
                code.Add("\n\tvoid bindAnimChr_and_setUpdateRate(const char* name, int unk, float unk2, float rate);");
            }

            // Collisions Stuff
            if (Program.currentProject.spriteType == 1)
            {
                code.Add("\n\tstatic dActor_c* build();");
                code.Add("\n\tvoid playerCollision(ActivePhysics *apThis, ActivePhysics *apOther);" +
                         "\n\tvoid spriteCollision(ActivePhysics* apThis, ActivePhysics* apOther); " +
                         "\n\tvoid yoshiCollision(ActivePhysics* apThis, ActivePhysics* apOther);");

            } else
            {
                code.Add(String.Format("\n\tstatic {0}* build();", Program.currentProject.spriteClassName));
            }

            // Model Stuff
            if (Program.currentProject.spriteHasModel)
            {
                code.Add("\n\tmHeapAllocator_c allocator;" +
                         "\n\tm3d::mdl_c bodyModel;" +
                         "\n\tm3d::anmChr_c animationChr;" +
                         "\n\tnw4r::g3d::ResFile resFile;");
            }


            // States
            if (Program.currentProject.spriteStates != null)
            {
                code.Add(String.Format("\n\tUSING_STATES({0})", Program.currentProject.spriteClassName));

                foreach (string str in Program.currentProject.spriteStates)
                {
                    code.Add(String.Format("\tDECLARE_STATE({0})", str));
                }

                code.Add("\n};\n");

                foreach (string str in Program.currentProject.spriteStates)
                {
                    code.Add(String.Format("CREATE_STATE({0}, {1})",
                                 Program.currentProject.spriteClassName, 
                                 str));
                }
            } else
            {
                code.Add("};");
            }

            if (Program.currentProject.spriteHasModel)
            {
                code.Add(String.Format("\nvoid {0}::UpdateModelMatrices() {{" +
                                       "\n\tmatrix.translation(pos.x, pos.y, pos.z);" +
                                       "\n\tmatrix.applyRotationYXZ(&rot.x, &rot.y, &rot.z);" +
                                       "\n\n\tbodyModel.setDrawMatrix(matrix);" +
                                       "\n\tbodyModel.setScale(&scale);" +
                                       "\n\tbodyModel.calcWorld(false);" +
                                       "\n}}", Program.currentProject.spriteClassName));

                if (Program.currentProject.spriteHasAnimation)
                {
                    code.Add(String.Format("\nvoid {0}::bindAnimChr_and_setUpdateRate(const char* name, int unk, float unk2, float rate) {{" +
                                       "\n\tnw4r::g3d::ResAnmChr anmChr = this->resFile.GetResAnmChr(name);" +
                                       "\n\tthis->animationChr.bind(&this->bodyModel, anmChr, unk);" +
                                       "\n\tthis->bodyModel.bindAnim(&this->animationChr, unk2);" +
                                       "\n\tthis->animationChr.setUpdateRate(rate);" +
                                       "\n}}", Program.currentProject.spriteClassName));
                }
            }

            if (Program.currentProject.spriteType == 0)
            {
                code.Add(String.Format("\n{0}* {0}::build() {{", Program.currentProject.spriteClassName));
            } else
            {
                code.Add(String.Format("\ndActor_c* {0}::build() {{", Program.currentProject.spriteClassName));
            }

            code.Add(String.Format("\tvoid* buffer = AllocFromGameHeap1(sizeof({0}));" +
                                       "\n\treturn new(buffer) {0};" +
                                       "\n}}", Program.currentProject.spriteClassName));

            if (Program.currentProject.spriteType == 0)
            {
                code.Add(String.Format("\nconst SpriteData {0}SpriteData = {{", Program.currentProject.spriteName));
                code.Add(String.Format("\tProfileId::{11}, {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} \n}};",
                                       Program.currentProject.newSprite.offsets.x,
                                       Program.currentProject.newSprite.offsets.y,
                                       Program.currentProject.newSprite.distancesToCenter.x,
                                       Program.currentProject.newSprite.distancesToCenter.y,
                                       Program.currentProject.newSprite.distancesToEdge.x,
                                       Program.currentProject.newSprite.distancesToEdge.y,
                                       Program.currentProject.newSprite._1C,
                                       Program.currentProject.newSprite._1E,
                                       Program.currentProject.newSprite._20,
                                       Program.currentProject.newSprite._22,
                                       Program.currentProject.newSprite.flags,
                                       Program.currentProject.spriteProfileID));

                code.Add(String.Format("\n\nProfile {0}Profile(&{1}::build, " +
                                       "SpriteId::{2}, " +
                                       "{0}SpriteData, " +
                                       "ProfileId::{3}, " +
                                       "ProfileId::{3}, " +
                                       "\"{0}\", " +
                                       "{4}" +
                                       ");",
                                       Program.currentProject.spriteName,
                                       Program.currentProject.spriteClassName,
                                       Program.currentProject.spriteID,
                                       Program.currentProject.spriteProfileID,
                                       Program.currentProject.spriteARCNameList
                                       ));
            }

            code.Add(String.Format("\nint {0}::onCreate() {{", Program.currentProject.spriteClassName));

            if (Program.currentProject.spriteHasModel)
            {
                code.Add(String.Format("\tallocator.link(-1, GameHeaps[0], 0, 0x20);" +
                                       "\n\tresFile.data = getResource(\"{0}\", \"g3d/{1}.brres\");" +
                                       "\n\tnw4r::g3d::ResMdl mdl = this->resFile.GetResMdl(\"{2}\");" +
                                       "\n\tbodyModel.setup(mdl, &allocator, 0x224, 1, 0);" +
                                       "\n\tSetupTextures_{3}(&bodyModel, 0);", 
                                       Program.currentProject.modelARCName,
                                       Program.currentProject.modelBRRESName,
                                       Program.currentProject.modelMDL0Name,
                                       Program.currentProject.spriteLightmapType));

                if (Program.currentProject.spriteHasAnimation)
                {
                    code.Add(String.Format("\n\tnw4r::g3d::ResAnmChr anmChr = this->resFile.GetResAnmChr(\"{0}\");" +
                                           "\n\tthis->animationChr.setup(mdl, anmChr, &this->allocator, 0);",
                                           Program.currentProject.modelCHR0Name));
                }

                code.Add(String.Format("\n\tallocator.unlink();" +
                                       "\n\n\tActivePhysics::Info HitBox;" +
                                       "\n\tHitBox.xDistToCenter = {0};" +
                                       "\n\tHitBox.yDistToCenter = {1};" +
                                       "\n\tHitBox.xDistToEdge = {2};" +
                                       "\n\tHitBox.yDistToEdge = {3};" +
                                       "\n\tHitBox.category1 = 0x{4};" +
                                       "\n\tHitBox.category2 = 0x{5};" +
                                       "\n\tHitBox.bitfield1 = 0x4F;" +
                                       "\n\tHitBox.bitfield2 = {6};" +
                                       "\n\tHitBox.unkShort1C = 0;" +
                                       "\n\tHitBox.callback = &dEn_c::collisionCallback;" +
                                       "\n\tthis->aPhysics.initWithStruct(this, &HitBox);" +
                                       "\n\tthis->aPhysics.addToList();" +
                                       "\n\n\tthis->scale.x = {7};" +
                                       "\n\tthis->scale.y = {8};" +
                                       "\n\tthis->scale.z = {9};",
                                       Program.currentProject.replacementSprite.distancesToCenter.x,
                                       Program.currentProject.replacementSprite.distancesToCenter.y,
                                       Program.currentProject.replacementSprite.distancesToEdge.x,
                                       Program.currentProject.replacementSprite.distancesToEdge.y,
                                       Program.currentProject.category1,
                                       Program.currentProject.category2,
                                       Program.currentProject.bitField2,
                                       Program.currentProject.replacementSprite.scale.x,
                                       Program.currentProject.replacementSprite.scale.y,
                                       Program.currentProject.replacementSprite.scale.z));

                if (Program.currentProject.spriteHasAnimation)
                {
                    code.Add(String.Format("\n\tbindAnimChr_and_setUpdateRate(\"{0}\", 1, 0.0, 1.0);",
                                                              Program.currentProject.modelCHR0Name));

                    code.Add(String.Format("\n\tdoStateChange(&StateID_{0});", Program.currentProject.spriteStates[0]));
                }
            }

            code.Add("\n\tthis->onExecute();" +
                     "\n\treturn true;" +
                     "\n}");

            code.Add(String.Format("\nint {0}::onExecute() {{", Program.currentProject.spriteClassName));

            code.Add("\tacState.execute();");

            if (Program.currentProject.spriteHasModel)
            {
                code.Add("\n\tupdateModelMatrices();" +
                         "\n\tbodyModel._vf1C();");

                if (Program.currentProject.spriteHasAnimation)
                {
                    code.Add("\n\tif(this->animationChr.isAnimationDone()) {" +
                             "\n\t\tthis->animationChr.setCurrentFrame(0.0);" +
                             "\n\t}");
                }
            }

            code.Add("\n\treturn true;" +
                     "\n}");

            code.Add(String.Format("\nint {0}::onDelete() {{" +
                                   "\n\treturn true;" +
                                   "\n\nint {0}::onDraw() {{",
                                   Program.currentProject.spriteClassName));

            if (Program.currentProject.spriteHasModel)
            {
                code.Add("\tbodyModel.scheduleForDrawing();");
            }

            code.Add("\n\treturn true;");

            code.Add("\n#pragma region States");

            foreach(string s in Program.currentProject.spriteStates)
            {
                code.Add(String.Format("\nvoid {0}::beginState_{1}() {{\n\n}}",
                                        Program.currentProject.spriteClassName,
                                        s));
                code.Add(String.Format("void {0}::executeState_{1}() {{\n\n}}",
                                        Program.currentProject.spriteClassName,
                                        s));
                code.Add(String.Format("void {0}::endState_{1}() {{\n\n}}",
                                        Program.currentProject.spriteClassName,
                                        s));
            }

            code.Add("\n#pragma endregion");

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "C++ Source Files|*.cpp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(sfd.FileName, code);
            }
        }
    }
}
