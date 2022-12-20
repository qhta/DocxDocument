namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public partial interface People
{
  public Collection<DocumentModel.Wordprocessing.Person>? Persons { get; set; }
  
}
