namespace DocxDocument.Model;

/// <summary>
/// Represents the shadow of an element.
/// </summary>
public class ShadowFormat
{
  /// <summary> 
  /// Returns or sets the shape shadow type.
  ///</summary> 
  public ShadowType? Type { get; set; }

  /// <summary> 
  /// Returns or sets a MsoShadowType that represents the type of shadow formatting to apply to a shape. Read/write.
  ///</summary> 
  public ShadowStyle? Style { get; set; }

  /// <summary> 
  /// Returns or sets a ColorFormat object that represents the foreground color for the shadow.
  ///</summary> 
  public ColorFormat? ForeColor { get; set; }

  /// <summary> 
  /// MsoTrue if the shadow of the specified shape appears filled in and is obscured by the shape, even if the shape has no fill. MsoFalse if the shadow has no fill and the outline of the shadow is visible through the shape if the shape has no fill.
  ///</summary> 
  public bool? Obscured { get; set; }

  /// <summary> 
  /// Returns or sets the horizontal offset (in points) of the shadow from the specified shape. A positive value offsets the shadow to the right of the shape; a negative value offsets it to the left.
  ///</summary> 
  public float? OffsetX { get; set; }

  /// <summary> 
  /// Returns or sets the vertical offset (in points) of the shadow from the specified shape. A positive value offsets the shadow below the shape; a negative value offsets it above the shape.
  ///</summary> 
  public float? OffsetY { get; set; }

  /// <summary> 
  /// Returns or sets an MsoTriState that represents whether to rotate the shadow when rotating the shape. Read/write.
  ///</summary> 
  public bool? RotateWithShape { get; set; }

  /// <summary> 
  /// Returns or sets a Single that represents the width of the shadow. Read/write.
  ///</summary> 
  public float? Size { get; set; }

  /// <summary> 
  /// Returns or sets a Single that represents the blur level for a shadow format.
  ///</summary> 
  public float? Blur { get; set; }

  /// <summary> 
  /// Returns or sets the degree of transparency of the specified fill, shadow, or line as a value between 0.0 (opaque) and 1.0 (clear).
  ///</summary> 
  public float? Transparency { get; set; }

  /// <summary> 
  /// True if the specified object, or the formatting applied to it, is visible
  ///</summary> 
  public bool? Visible { get; set; }


}