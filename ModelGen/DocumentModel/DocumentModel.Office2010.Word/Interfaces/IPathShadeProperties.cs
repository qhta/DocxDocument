namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public interface IPathShadeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PathShadeKind? Path { get ; set; }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public DocumentModel.Office2010.Word.IFillToRectangle? FillToRectangle { get ; set; }
  
}
