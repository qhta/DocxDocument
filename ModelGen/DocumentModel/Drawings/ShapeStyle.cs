namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the style information for a shape.
/// </summary>
public partial class ShapeStyle
{
  
  /// <summary>
  ///   LineReference.
  /// </summary>
  public DMD.LineReference? LineReference { get; set; }
  
  
  /// <summary>
  ///   FillReference.
  /// </summary>
  public DMD.FillReference? FillReference { get; set; }
  
  
  /// <summary>
  ///   EffectReference.
  /// </summary>
  public DMD.EffectReference? EffectReference { get; set; }
  
  
  /// <summary>
  ///   Font Reference.
  /// </summary>
  public DMD.FontReference? FontReference { get; set; }
  
}
