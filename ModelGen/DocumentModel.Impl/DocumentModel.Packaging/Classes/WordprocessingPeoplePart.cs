namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPeoplePart
/// </summary>
public class WordprocessingPeoplePartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, WordprocessingPeoplePart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Wordprocessing.People? People
  {
    get;
    set;
  }
  
}
