using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ColorFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  int RGB { get; set; }
  int SchemeColor { get; set; }
  MsoColorType Type { get; }
  float TintAndShade { get; set; }
  MsoThemeColorIndex ObjectThemeColor { get; set; }
  float Brightness { get; set; }
}