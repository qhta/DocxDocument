namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a bookmark in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for the bookmark start and end elements, enabling advanced referencing, navigation, and content marking within the document.
/// </summary>
[DataContract]
[XmlRoot("Bookmark", Namespace = "DocumentModel.Wordprocessing")]
public partial class Bookmark : ModelElement
{
  /// <summary>
  /// Start element of the bookmark, specifying the location where the bookmark begins.
  /// </summary>
  public BookmarkStart? Start { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// End element of the bookmark, specifying the location where the bookmark ends.
  /// </summary>
  public BookmarkEnd? End { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}