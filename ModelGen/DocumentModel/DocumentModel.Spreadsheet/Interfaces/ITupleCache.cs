namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleCache Class.
/// </summary>
public interface ITupleCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Entries.
  /// </summary>
  public DocumentModel.Spreadsheet.IEntries? Entries { get ; set; }
  
  /// <summary>
  /// Sets.
  /// </summary>
  public DocumentModel.Spreadsheet.ISets? Sets { get ; set; }
  
  /// <summary>
  /// OLAP Query Cache.
  /// </summary>
  public DocumentModel.Spreadsheet.IQueryCache? QueryCache { get ; set; }
  
  /// <summary>
  /// Server Formats.
  /// </summary>
  public DocumentModel.Spreadsheet.IServerFormats? ServerFormats { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
