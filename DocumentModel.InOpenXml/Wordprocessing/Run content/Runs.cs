namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of run elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Run"/> objects, enabling advanced organization and manipulation of run structures within the document.
/// </summary>
public class Runs : ContentItemsQuery<Run>
{
  /// <summary>
  /// Default constructor for the Runs class, initializing a new instance of the Runs collection.
  /// </summary>
  public Runs(ModelElement parent, ContentItemsCollection baseCollection) : base(parent, baseCollection) { }


}