namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Shape Style.
/// </summary>
public interface IStyle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawing.IStyleMatrixReferenceType? LineReference { get ; set; }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawing.IStyleMatrixReferenceType? FillReference { get ; set; }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawing.IStyleMatrixReferenceType? EffectReference { get ; set; }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public DocumentModel.Drawing.IFontReference? FontReference { get ; set; }
  
}
