namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TupleCache Class.
/// </summary>
public interface TupleCache // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Entries.
  /// </summary>
  public Entries? Entries { get ; set; }
  
  /// <summary>
  /// Sets.
  /// </summary>
  public Sets? Sets { get ; set; }
  
  /// <summary>
  /// OLAP Query Cache.
  /// </summary>
  public QueryCache? QueryCache { get ; set; }
  
  /// <summary>
  /// Server Formats.
  /// </summary>
  public ServerFormats? ServerFormats { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
