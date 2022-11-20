namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IFillToRectangle))]
public interface IPathShadeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public PathShadeTypeValues? Path { get ; set; }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public DocumentModel.Office2010.Word.IFillToRectangle? FillToRectangle { get ; set; }
  
}
