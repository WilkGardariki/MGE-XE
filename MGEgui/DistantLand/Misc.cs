using System;
using MGEgui.DirectX;

namespace MGEgui.DistantLand {
    struct RGB {
        
        public byte r;
        public byte g;
        public byte b;
        public byte x;

        public RGB(byte _r, byte _g, byte _b) {
            r=_r;
            g=_g;
            b=_b;
            x=0;
        }

        public static implicit operator int(RGB s) {
            return System.Drawing.Color.FromArgb(s.r, s.g, s.b).ToArgb();
        }

        public static readonly RGB White = new RGB((byte)255, (byte)255, (byte)255);
    }

    struct Normal {
        private float x,y,z;
        public float X { get { return x; } }
        public float Y { get { return y; } }
        public float Z { get { return z; } }
        public Normal(sbyte X, sbyte Y, sbyte Z) {
            x=X;
            y=Y;
            z=Z;
            float mag=(float)Math.Sqrt(x*x+y*y+z*z);
            x/=mag;
            y/=mag;
            z/=mag;
        }
        public Normal(float X, float Y, float Z) {
            x=X; y=Y; z=Z;
        }

        public static readonly Normal Up=new Normal(0f, 0f, 1f);

        public static Normal operator+(Normal a, Normal b) {
            return new Normal(a.x+b.x, a.y+b.y, a.z+b.z);
        }

        public static Normal operator/(Normal a, float b) {
            return new Normal(a.x/b, a.y/b, a.z/b);
        }
    }

    class LAND {
        public readonly int[,] Heights=new int[65,65];
        public readonly RGB[,] Color=new RGB[65,65];
        public readonly Normal[,] Normals=new Normal[65, 65];
        public readonly int[,] Tex=new int[16,16];

        public int xpos=-999;
        public int ypos=-999;

        public System.Collections.Generic.List<LTEX> Textures;

        public LAND() {
            for(int y=0;y<65;y++) {
                for(int x=0;x<65;x++) {
                    Color[x, y]=RGB.White;
                    Normals[x, y]=Normal.Up;
                    Heights[x, y]=-256;
                }
            }
        }
    }

    class LTEXSorter : System.Collections.Generic.IComparer<LTEX> {
        public int Compare(LTEX a, LTEX b) {
			return a.index.CompareTo(b.index);
        }
    }
}