namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Run.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IText))]
public interface IRun // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Spreadsheet.IText? Text { get ; set; }
  
}
