namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the style information for a shape.
/// </summary>
public partial class ShapeStyle
{
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  public LineReference? LineReference { get; set; }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  public FillReference? FillReference { get; set; }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  public EffectReference? EffectReference { get; set; }
  
  
  /// <summary>
  ///   Font Reference.
  /// </summary>
  public FontReference? FontReference { get; set; }
  
}
