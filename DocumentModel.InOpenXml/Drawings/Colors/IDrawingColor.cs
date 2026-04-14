namespace DocumentModel.Drawings;

/// <summary>
/// Interface to represent a color for drawing elements.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(RgbColorModelHex), "rgbHex")]
[JsonDerivedType(typeof(RgbColorModelPercentage), "rgbPct")]
[JsonDerivedType(typeof(HslColor), "hsl")]
[JsonDerivedType(typeof(SystemColor), "sys")]
[JsonDerivedType(typeof(SchemeColor), "scheme")]
[JsonDerivedType(typeof(PresetColor), "preset")]
public interface IDrawingColor
{
  
}