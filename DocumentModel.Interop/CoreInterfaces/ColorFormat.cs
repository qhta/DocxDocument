using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ColorFormat: InteropObject
{
  public int RGB { get; set; }
  public int SchemeColor { get; set; }
  public MsoColorType Type { get; }
  public float TintAndShade { get; set; }
  public MsoThemeColorIndex ObjectThemeColor { get; set; }
  public float Brightness { get; set; }
}
