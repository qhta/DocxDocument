namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? RunProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? Text { get ; set; }
  
}
