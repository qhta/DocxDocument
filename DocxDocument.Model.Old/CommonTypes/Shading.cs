namespace DocxDocument.Model;

/// <summary>
/// Represents shading of an object.
/// </summary>
public class Shading
{
  /// <summary> 
  /// Returns or sets the shading texture for the specified object.
  ///</summary> 
  public TextureIndex? Texture { get; set; }

  /// <summary> 
  /// Returns or sets the 24-bit color that's applied to the foreground of the Shading object. This color is applied to the dots and lines in the shading pattern. Can be any valid WdColor constant or a value returned by Visual Basic's RGB function.
  ///</summary> 
  public Color? ForegroundPatternColor { get; set; }

  /// <summary> 
  /// Returns or sets the color that's applied to the foreground of the Shading object. This color is applied to the dots and lines in the shading pattern.
  ///</summary> 
  public ColorIndex? ForgroundPatternColorIndex { get; set; }

  /// <summary> 
  /// Returns or sets the 24-bit color that's applied to the background of the Shading object. Can be any valid WdColor constant or a value returned by Visual Basic's RGB function.
  ///</summary> 
  public Color? BackgroundPatternColor { get; set; }

  /// <summary> 
  /// Returns or sets the color that's applied to the background of the Shading object.
  ///</summary> 
  public ColorIndex? BackgroundPatternColorIndex { get; set; }


}