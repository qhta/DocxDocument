namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comments Collection.
/// </summary>
public partial class Comments
{
  public ElementCollection<Comment>? Items { get; set; }
  
}
