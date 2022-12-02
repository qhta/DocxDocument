namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleCache Class.
/// </summary>
public interface ITupleCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Entries.
  /// </summary>
  public IEntries? Entries { get ; set; }
  
  /// <summary>
  /// Sets.
  /// </summary>
  public ISets? Sets { get ; set; }
  
  /// <summary>
  /// OLAP Query Cache.
  /// </summary>
  public IQueryCache? QueryCache { get ; set; }
  
  /// <summary>
  /// Server Formats.
  /// </summary>
  public IServerFormats? ServerFormats { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
