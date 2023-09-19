namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies contact information for each person who is the author of at least one comment or revision in the current document.
/// </summary>
public partial class People
{
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.Person>? Items { get; set; }
  
}
