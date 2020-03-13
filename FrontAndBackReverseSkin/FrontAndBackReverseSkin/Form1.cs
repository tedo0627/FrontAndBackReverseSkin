using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FrontAndBackReverseSkin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png files (*.png)|*.png";
            openFileDialog1.Title = "スキンの画像を選択してください";
            openFileDialog1.FileName = "skin.ping";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                String text = openFileDialog1.FileName;
                basePath.Text = text;
                if (text.Contains(".png") && createPath.Text == "")
                {
                    createPath.Text = text.Replace(".png", "_reverse.png");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "png files (*.png)|*.png";
            openFileDialog1.Title = "スキンの保存先の画像を選択してください";
            openFileDialog1.FileName = "skin.ping";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                createPath.Text = openFileDialog1.FileName;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (basePath.Text == "")
            {
                MessageBox.Show("元のスキンを選択してください");
                return;
            }

            if (!File.Exists(basePath.Text))
            {
                MessageBox.Show("元のスキンが見つかりませんでした");
                return;
            }

            if (createPath.Text == "")
            {
                MessageBox.Show("保存先を選択してください");
                return;
            }

            Bitmap read = new Bitmap(basePath.Text);
            Bitmap write = new Bitmap(basePath.Text);

            Head(read, write, false);
            Head(read, write, true);

            RightLeg(read, write, false);
            RightLeg(read, write, true);

            LeftLeg(read, write, false);
            LeftLeg(read, write, true);

            Body(read, write, false);
            Body(read, write, true);

            RightArm(read, write, false);
            RightArm(read, write, true);

            LeftArm(read, write, false);
            LeftArm(read, write, true);

            write.Save(createPath.Text);

            read.Dispose();
            write.Dispose();

            MessageBox.Show("処理が完了しました");
        }

        private void Head(Bitmap read, Bitmap write, Boolean outSide)
        {
            CutOut(read, write, 8, 8, 8, 0, 8, 0, RotateFlipType.Rotate180FlipNone, outSide, 32, 0); //上
            CutOut(read, write, 8, 8, 16, 0, 16, 0, RotateFlipType.Rotate180FlipNone, outSide, 32, 0); //下

            CutOut(read, write, 8, 8, 0, 8, 16, 8, null, outSide, 32, 0); //左
            CutOut(read, write, 8, 8, 8, 8, 24, 8, null, outSide, 32, 0); //正面
            CutOut(read, write, 8, 8, 16, 8, 0, 8, null, outSide, 32, 0); //右
            CutOut(read, write, 8, 8, 24, 8, 8, 8, null, outSide, 32, 0); //後ろ
        }

        private void RightLeg(Bitmap read, Bitmap write, Boolean outSide)
        {
            CutOut(read, write, 4, 4, 4, 16, 4, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //上
            CutOut(read, write, 4, 4, 8, 16, 8, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //下

            CutOut(read, write, 4, 12, 0, 20, 8, 20, null, outSide, 0, 16); //左
            CutOut(read, write, 4, 12, 4, 20, 12, 20, null, outSide, 0, 16); //正面
            CutOut(read, write, 4, 12, 8, 20, 0, 20, null, outSide, 0, 16); //右
            CutOut(read, write, 4, 12, 12, 20, 4, 20, null, outSide, 0, 16); //後ろ
        }

        private void LeftLeg(Bitmap read, Bitmap write, Boolean outSide)
        {
            CutOut(read, write, 4, 4, 4, 48, 4, 48, RotateFlipType.Rotate180FlipNone, outSide, 16, 0); //上
            CutOut(read, write, 4, 4, 8, 48, 8, 48, RotateFlipType.Rotate180FlipNone, outSide, 16, 0); //下

            CutOut(read, write, 4, 12, 0, 52, 8, 52, null, outSide, 16, 0); //左
            CutOut(read, write, 4, 12, 4, 52, 12, 52, null, outSide, 16, 0); //正面
            CutOut(read, write, 4, 12, 8, 52, 0, 52, null, outSide, 16, 0); //右
            CutOut(read, write, 4, 12, 12, 52, 4, 52, null, outSide, 16, 0); //後ろ
        }

        private void Body(Bitmap read, Bitmap write, Boolean outSide)
        {
            CutOut(read, write, 8, 4, 20, 16, 20, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //上
            CutOut(read, write, 8, 4, 28, 16, 28, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //下

            CutOut(read, write, 4, 12, 16, 20, 28, 20, null, outSide, 0, 16); //左
            CutOut(read, write, 8, 12, 20, 20, 32, 20, null, outSide, 0, 16); //正面
            CutOut(read, write, 4, 12, 28, 20, 16, 20, null, outSide, 0, 16); //右
            CutOut(read, write, 8, 12, 32, 20, 20, 20, null, outSide, 0, 16); //後ろ
        }

        private void RightArm(Bitmap read, Bitmap write, Boolean outSide)
        {
            if (slimCheck.Checked)
            {
                CutOut(read, write, 3, 4, 44, 16, 44, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //上
                CutOut(read, write, 3, 4, 47, 16, 47, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //下

                CutOut(read, write, 4, 12, 40, 20, 47, 20, null, outSide, 0, 16); //左
                CutOut(read, write, 3, 12, 44, 20, 51, 20, null, outSide, 0, 16); //正面
                CutOut(read, write, 4, 12, 47, 20, 40, 20, null, outSide, 0, 16); //右
                CutOut(read, write, 3, 12, 51, 20, 44, 20, null, outSide, 0, 16); //後ろ
            }
            else
            {
                CutOut(read, write, 4, 4, 44, 16, 44, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //上
                CutOut(read, write, 4, 4, 48, 16, 48, 16, RotateFlipType.Rotate180FlipNone, outSide, 0, 16); //下

                CutOut(read, write, 4, 12, 40, 20, 48, 20, null, outSide, 0, 16); //左
                CutOut(read, write, 4, 12, 44, 20, 52, 20, null, outSide, 0, 16); //正面
                CutOut(read, write, 4, 12, 48, 20, 40, 20, null, outSide, 0, 16); //右
                CutOut(read, write, 4, 12, 52, 20, 44, 20, null, outSide, 0, 16); //後ろ
            }
        }

        private void LeftArm(Bitmap read, Bitmap write, Boolean outSide)
        {
            if (slimCheck.Checked)
            {
                CutOut(read, write, 3, 4, 36, 48, 36, 48, RotateFlipType.Rotate180FlipNone, outSide, 16, 0); //上
                CutOut(read, write, 3, 4, 39, 48, 39, 48, RotateFlipType.Rotate180FlipNone, outSide, 16, 0); //下

                CutOut(read, write, 4, 12, 32, 52, 39, 52, null, outSide, 16, 0); //左
                CutOut(read, write, 3, 12, 35, 52, 43, 52, null, outSide, 16, 0); //正面
                CutOut(read, write, 4, 12, 39, 52, 32, 52, null, outSide, 16, 0); //右
                CutOut(read, write, 3, 12, 43, 52, 35, 52, null, outSide, 16, 0); //後ろ
            }
            else
            {
                CutOut(read, write, 4, 4, 36, 48, 36, 48, RotateFlipType.Rotate180FlipNone, outSide, 16, 0); //上
                CutOut(read, write, 4, 4, 40, 48, 40, 48, RotateFlipType.Rotate180FlipNone, outSide, 16, 0); //下

                CutOut(read, write, 4, 12, 32, 52, 40, 52, null, outSide, 16, 0); //左
                CutOut(read, write, 4, 12, 36, 52, 44, 52, null, outSide, 16, 0); //正面
                CutOut(read, write, 4, 12, 40, 52, 32, 52, null, outSide, 16, 0); //右
                CutOut(read, write, 4, 12, 44, 52, 36, 52, null, outSide, 16, 0); //後ろ
            }
        }

        private void CutOut(Bitmap read, Bitmap write, int pixelX, int pixelY, int cutX, int cutY, int putX, int putY, RotateFlipType? rotateType, Boolean outSide = false, int outOffsetX = 0, int outOffsetY = 0)
        {
            Bitmap cut = new Bitmap(pixelX, pixelY);
            for (int y = 0; y < pixelY; ++y)
            {
                for (int x = 0; x < pixelX; ++x)
                {
                    cut.SetPixel(x, y, read.GetPixel(x + cutX + (outSide ? outOffsetX : 0), y + cutY + (outSide ? outOffsetY : 0)));
                }
            }

            if (rotateType.HasValue)
            {
                cut.RotateFlip(rotateType.Value);
            }

            for (int y = 0; y < pixelY; ++y)
            {
                for (int x = 0; x < pixelX; ++x)
                {
                    write.SetPixel(x + putX + (outSide ? outOffsetX : 0), y + putY + (outSide ? outOffsetY : 0), cut.GetPixel(x, y));
                }
            }

            cut.Dispose();
        }
    }
}
