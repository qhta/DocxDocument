namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public partial interface People
{
  /// <summary>
  /// Gets the WordprocessingPeoplePart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordprocessingPeoplePart? WordprocessingPeoplePart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.Person>? Persons { get; set; }
  
}
