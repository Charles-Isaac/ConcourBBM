﻿
using Microsoft.Xna.Framework.Graphics;

namespace CompetitionV2
{
    public class CaseVide : AbsCase
    {
        //private Bomb _bomb;
        public CaseVide(int x, int y, Map parent) : base(x, y, parent, false, true, true)
        {
            //_bomb = null;
        }

        //public bool ContainsBomb => _bomb != null;

        /*public Bomb Bomb
        {
            get
            {
                return _bomb; // null if there's no bomb
            }
            set
            {
                _bomb = value;
                LetsFireThrough = value == null;
            }
        }*/

        public override bool IsSolid => false;// _bomb != null;

        public override CaseType Type => CaseType.Vide;

        public override Texture2D Texture => TextureManager.Instance.TextureCaseVide;
    }
}
