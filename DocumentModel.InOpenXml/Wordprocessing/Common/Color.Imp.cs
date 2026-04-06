namespace DocumentModel.Wordprocessing;

public partial class Color: IColor
{
  UInt32 IColor.Val { get => this.Val ?? 0; set => this.Val = value; }

  ThemeColors? IColor.ThemeColor
  {
    get => this.ThemeColor;
    set => this.ThemeColor = value;
  }

  float? IColor.ThemeTint
  {
    get => this.ThemeTint is null ? null : 1-(float)(this.ThemeTint / 255.0);
    set => ThemeTint = value is null ? null : (byte)System.Math.Round(1-(double)value * 255.0);
  }

  float? IColor.ThemeShade
  {
    get => this.ThemeShade is null ? null : (float)(this.ThemeShade / 255.0);
    set => ThemeShade = value is null ? null : (byte)System.Math.Round((double)value * 255.0);
  }
}