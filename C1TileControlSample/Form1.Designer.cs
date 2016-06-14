namespace C1TileControlSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this.c1TileControl1 = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.group2 = new C1.Win.C1Tile.Group();
            this.tile4 = new C1.Win.C1Tile.Tile();
            this.tile5 = new C1.Win.C1Tile.Tile();
            this.SuspendLayout();
            // 
            // c1TileControl1
            // 
            this.c1TileControl1.AllowChecking = true;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement1);
            this.c1TileControl1.Groups.Add(this.group1);
            this.c1TileControl1.Groups.Add(this.group2);
            this.c1TileControl1.Location = new System.Drawing.Point(33, 49);
            this.c1TileControl1.Name = "c1TileControl1";
            this.c1TileControl1.Size = new System.Drawing.Size(754, 320);
            this.c1TileControl1.TabIndex = 0;
            this.c1TileControl1.Text = "c1TileControl1";
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Text = "グループ１";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "タイル１";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "タイル２";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "タイル３";
            // 
            // group2
            // 
            this.group2.Name = "group2";
            this.group2.Text = "グループ ２";
            this.group2.Tiles.Add(this.tile4);
            this.group2.Tiles.Add(this.tile5);
            // 
            // tile4
            // 
            this.tile4.Name = "tile4";
            this.tile4.Text = "タイル ４";
            // 
            // tile5
            // 
            this.tile5.Name = "tile5";
            this.tile5.Text = "タイル ５";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 598);
            this.Controls.Add(this.c1TileControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Tile.C1TileControl c1TileControl1;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private C1.Win.C1Tile.Group group2;
        private C1.Win.C1Tile.Tile tile4;
        private C1.Win.C1Tile.Tile tile5;
    }
}

