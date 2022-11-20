namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousTableProperties))]
public class TablePropertiesChange: ITablePropertiesChange
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Table Properties.
  /// </summary>
  public IPreviousTableProperties? PreviousTableProperties
  {
    get;
    set;
  }
  
}
