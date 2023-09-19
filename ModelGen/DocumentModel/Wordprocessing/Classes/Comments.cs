namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comments Collection.
/// </summary>
public partial class Comments
{
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.Comment>? Items { get; set; }
  
}
