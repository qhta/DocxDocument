namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the content of a single comment stored in the Comments part of a WordprocessingML document.
/// </summary>
public class Comment: ElementCollection<ICommentContent>
{
  /// <summary>
  ///   Specifies a unique identifier for an annotation.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   Specifies the author for an annotation.
  /// </summary>
  public string? Author { get; set; }
  /// <summary>
  ///   Specifies the initials of the author of the current comment. 
  ///   This information can be used to format and present the associated comment information block (§17.13.4.1), 
  ///   or in any user interface supported by an application. 
  ///   If there is more than one author with the same initials, 
  ///   it might be more useful to display the author name. 
  /// </summary>
  public string? Initials { get; set; }
  /// <summary>
  ///   Specifies the date information for an annotation.
  /// </summary>
  public DateTime? Date { get; set; }
  /// <summary>
  ///   Identifier of the first paragraph in the comment.
  /// </summary>
  public IHexInt? ParaId { get; set; }
  /// <summary>
  ///   Durable identifier of the comment.
  /// </summary>
  public IHexInt? DurableId { get; set; }
}