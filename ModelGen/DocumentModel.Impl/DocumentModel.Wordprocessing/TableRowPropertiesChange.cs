namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousTableRowProperties))]
public class TableRowPropertiesChange: ITableRowPropertiesChange
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
  /// Previous Table Row Properties.
  /// </summary>
  public IPreviousTableRowProperties? PreviousTableRowProperties
  {
    get;
    set;
  }
  
}
