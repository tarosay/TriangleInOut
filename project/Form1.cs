using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleInOut
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 3Dの直交座標データ
        /// </summary>
        private class Point3D
        {
            public double x = 0.0;
            public double y = 0.0;
            public double z = 0.0;

            public Point3D(double xx, double yy, double zz)
            {
                this.x = xx;
                this.y = yy;
                this.z = zz;
            }

            /// <summary>
            /// 2点のベクトルを求めます
            /// </summary>
            /// <param name="b"></param>
            /// <returns></returns>
            public Vector3D sub_vector(Point3D b)
            {
                Vector3D ret = new Vector3D();

                ret.x = this.x - b.x;
                ret.y = this.y - b.y;
                ret.z = this.z - b.z;
                return ret;
            }
        }

        /// <summary>
        /// 3Dのベクトル成分
        /// </summary>
        private class Vector3D
        {
            public double x = 0.0;
            public double y = 0.0;
            public double z = 0.0;

            /// <summary>
            /// 外積を求めます
            /// </summary>
            /// <param name="vr"></param>
            /// <returns></returns>
            public Vector3D cross_product(Vector3D vr)
            {
                Vector3D ret = new Vector3D();
                ret.x = this.y * vr.z - this.z * vr.y;
                ret.y = this.z * vr.x - this.x * vr.z;
                ret.z = this.x * vr.y - this.y * vr.x;

                return ret;
            }

            /// <summary>
            /// 内積を求めます
            /// </summary>
            /// <param name="vr"></param>
            /// <returns></returns>
            public double dot_product(Vector3D vr)
            {
                return this.x * vr.x + this.y * vr.y + this.z * vr.z;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Judge_Click(object sender, EventArgs e)
        {
            double x, y, z;

            x = (double)nudPointAx.Value;
            y = (double)nudPointAy.Value;
            z = (double)nudPointAz.Value;
            Point3D A = new Point3D(x, y, z);

            x = (double)nudPointBx.Value;
            y = (double)nudPointBy.Value;
            z = (double)nudPointBz.Value;
            Point3D B = new Point3D(x, y, z);

            x = (double)nudPointCx.Value;
            y = (double)nudPointCy.Value;
            z = (double)nudPointCz.Value;
            Point3D C = new Point3D(x, y, z);

            x = (double)nudPointPx.Value;
            y = (double)nudPointPy.Value;
            z = (double)nudPointPz.Value;
            Point3D P = new Point3D(x, y, z);

            Vector3D AB = A.sub_vector(B);
            Vector3D BP = B.sub_vector(P);

            Vector3D BC = C.sub_vector(B);
            Vector3D CP = P.sub_vector(C);

            Vector3D CA = A.sub_vector(C);
            Vector3D AP = P.sub_vector(A);

            Vector3D c1 = AB.cross_product(BP);
            Vector3D c2 = BC.cross_product(CP);
            Vector3D c3 = CA.cross_product(AP);

            //内積で順方向か逆方向か調べる
            double dot_12 = c1.dot_product(c2);
            double dot_13 = c1.dot_product(c3);

            if (dot_12 > 0 && dot_13 > 0)
            {
                tbxJudge.Text = "三角形の内側に点がある";
            }
            else
            {
                tbxJudge.Text = "三角形の外側に点がある";
            }
        }
    }
}
