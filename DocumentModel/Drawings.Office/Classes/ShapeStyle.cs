namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the ShapeStyle Class.
/// </summary>
public partial class ShapeStyle
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawings.LineReference? LineReference { get; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawings.FillReference? FillReference { get; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawings.EffectReference? EffectReference { get; set; }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public DocumentModel.Drawings.FontReference? FontReference { get; set; }
  
}
