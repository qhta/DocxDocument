namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BookmarkEnd Class.
/// </summary>
public class BookmarkEnd: IBookmarkEnd
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlValues? DisplacedByCustomXml
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
