namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the CustomXmlConflictInsertionRangeStart Class.
/// </summary>
public class CustomXmlConflictInsertionRangeStart: ICustomXmlConflictInsertionRangeStart
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
  
}
