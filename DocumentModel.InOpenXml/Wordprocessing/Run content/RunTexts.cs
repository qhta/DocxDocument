namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of run-text elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "RunText"/> objects, enabling advanced organization and manipulation of run-text structures within the document.
/// </summary>
public class RunTexts : ContentItemsQuery<RunText>
{
  /// <summary>
  /// Default constructor for the RunTexts class, initializing a new instance of the RunTexts collection.
  /// </summary>
  public RunTexts(ModelElement parent, ContentItemsCollection baseCollection) : base(parent, baseCollection) { }


}