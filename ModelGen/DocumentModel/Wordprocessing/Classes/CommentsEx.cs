namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the additional information for all of the comments defined in the current document. It is the root element of the Comments Extended Part of a WordprocessingML document.
/// </summary>
public partial class CommentsEx
{
  public ElementCollection<CommentEx>? Items { get; set; }
  
}
