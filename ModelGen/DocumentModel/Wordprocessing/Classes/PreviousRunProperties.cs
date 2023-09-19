namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of run properties which shall be attributed to a revision by a particular author and at a particular time. This element contains the set of properties which have been tracked as a specific set of revisions by one author.
/// </summary>
public partial class PreviousRunProperties
{
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
