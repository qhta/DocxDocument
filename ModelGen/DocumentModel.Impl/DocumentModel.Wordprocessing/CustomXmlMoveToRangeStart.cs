namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlMoveToRangeStart Class.
/// </summary>
public class CustomXmlMoveToRangeStart: ICustomXmlMoveToRangeStart
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
