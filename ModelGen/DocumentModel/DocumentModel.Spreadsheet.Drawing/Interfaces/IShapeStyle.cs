namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Defines the ShapeStyle Class.
/// </summary>
public interface IShapeStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawing.IFillReference? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawing.IEffectReference? EffectReference { get ; set; }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public DocumentModel.Drawing.IFontReference? FontReference { get ; set; }
  
}
