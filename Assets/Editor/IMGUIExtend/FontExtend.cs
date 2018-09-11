using UnityEngine;

namespace IMGUIExtend
{
    public  static class FontExtend
    {
        public static Vector2 GetFontSize(this Font font, string str)
        {
            return GetFontSize(font, str, 0);
        }
        public static Vector2 GetFontSize(this Font font, string str, int fontsize)
        {
            return GetFontSize(font, str, fontsize, FontStyle.Normal);
        }
        public static Vector2 GetFontSize(this Font font, string str,int fontsize, FontStyle style)
        {
            Vector2 size = new Vector2(0,font.lineHeight);
            font.RequestCharactersInTexture(str,fontsize,style);
            for (var i = 0; i < str.Length; i++)
            {
                CharacterInfo info;
                font.GetCharacterInfo(str[i], out info,fontsize,style);
                size.x += info.advance;
            }
            return size;
        }
    }
}
