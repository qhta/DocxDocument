namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentRangeEnd Class.
/// </summary>
public class CommentRangeEnd: ICommentRangeEnd
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
