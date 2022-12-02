namespace DocumentModel.Spreadsheet;

/// <summary>
/// Rich Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public IXstringType? Text { get ; set; }
  
}
