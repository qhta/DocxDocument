namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CustomXmlInsRangeStart Class.
/// </summary>
public class CustomXmlInsRangeStart: ICustomXmlInsRangeStart
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
