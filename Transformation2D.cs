using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _62024_Antoni_Piwowarski_WinGraphics2D
{
    internal class Transformation2D
    {
        public static float[,] apRightTranslationMatrix(float aptx, float apty)
        {
            float[,] apR = { { 1, 0, 0 }, { 0, 1, 0 }, { aptx, apty, 1 } };
            return apR;
        }
        public static float[,] apRightRotationMatrix(double apangle)
        {
            float apsin = Convert.ToSingle(Math.Sin(apangle));
            float apcos = Convert.ToSingle(Math.Cos(apangle));
            float[,] apR = { { apcos, apsin, 0 }, { -apsin, apcos, 0 }, { 0, 0, 1 } };
            return apR;
        }
        public static float[,] apRightRotationAboutPointMatrix(float apx0, float apy0, double apangle)
        {
            float apsin = (float)Math.Sin(apangle);
            float apcos = (float)Math.Cos(apangle);
            float[,] apR = { { apcos, apsin, 0 }, { -apsin, apcos, 0 }, { apx0 * (1 - apcos) + apy0 * apsin, apy0 * (1 - apcos) - apx0 * apsin, 1 } };
            return apR;
        }
        public static float[,] apScalingMatrix(float apsx, float apsy)
        {
            float[,] apR = { { apsx, 0, 0 }, { 0, apsy, 0 }, { 0, 0, 1 } };
            return apR;
        }
        public static float[,] apMatrixMultiplication(float[,] apA, float[,] apB)
        {
            int aprownsNoA = apA.GetLength(0), apcolumnsNoA = apA.GetLength(1);
            int aprownsNoB = apB.GetLength(0), apcolumnsNoB = apB.GetLength(1);
            if (apcolumnsNoA == aprownsNoB)
            {
                float[,] apR = new float[aprownsNoA, apcolumnsNoB];
                float aptemp;
                for (int api = 0; api < aprownsNoA; api++)
                {
                    for (int apk = 0; apk < apcolumnsNoB; apk++)
                    {
                        aptemp = 0;
                        for (int apj = 0; apj < apcolumnsNoA; apj++)
                            aptemp += apA[api, apj] * apB[apj, apk];

                        apR[api, apk] = aptemp;
                    }
                }
                return apR;
            }
            else return null;
        }
        public static void apdisplayArray(float[,] apA, DataGridView apdataGridView)
        {
            string[] aprow = new string[apA.GetLength(1)];
            for (int api = 0;api < apA.GetLength(0);api++)
            {
                for(int apj = 0;apj < aprow.Length;apj++)
                    aprow[apj] = apA[api, apj].ToString();
                apdataGridView.Rows.Add(aprow);
            }
            apdataGridView.Rows.Add();
        }
        public static float[,] apReflectionXMatrix()
        {
            float[,] apR = { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
            return apR;
        }

        public static float[,] apReflectionYMatrix()
        {
            float[,] apR = { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            return apR;
        }
        public static float[,] apShearingXMatrix(float apsh_x)
        {
            float[,] apR = { { 1, apsh_x, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            return apR;
        }

        public static float[,] apShearingYMatrix(float apsh_y)
        {
            float[,] apR = { { 1, 0, 0 }, { apsh_y, 1, 0 }, { 0, 0, 1 } };
            return apR;
        }
    }
}
