namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the RstType Class.
/// </summary>
public interface IRstType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text.
  /// </summary>
  public IXstringType? Text { get ; set; }
  
}
