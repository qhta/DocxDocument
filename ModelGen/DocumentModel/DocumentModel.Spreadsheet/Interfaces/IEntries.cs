namespace DocumentModel.Spreadsheet;

/// <summary>
/// Entries.
/// </summary>
public interface IEntries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tuple Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public DocumentModel.Spreadsheet.IMissingItem? MissingItem { get ; set; }
  
  public DocumentModel.Spreadsheet.INumberItem? NumberItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IErrorItem? ErrorItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IStringItem? StringItem { get ; set; }
  
}
