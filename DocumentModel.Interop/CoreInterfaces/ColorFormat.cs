using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ColorFormat: InteropObject
{
  int RGB { get; set; }
  int SchemeColor { get; set; }
  MsoColorType Type { get; }
  float TintAndShade { get; set; }
  MsoThemeColorIndex ObjectThemeColor { get; set; }
  float Brightness { get; set; }
}