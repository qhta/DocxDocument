using System.Runtime.Serialization;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the abstract class for markup range elements in a WordprocessingML document.
/// This class is implemented by types such as <see cref = "BookmarkStart"/>, <see cref = "BookmarkEnd"/>, <see cref = "CommentRangeStart"/>, <see cref = "CommentRangeEnd"/>, <see cref = "MoveFromRangeStart"/>, <see cref = "MoveFromRangeEnd"/>, <see cref = "MoveToRangeStart"/>, and <see cref = "MoveToRangeEnd"/>.
/// Provides properties for linking annotations and managing the placement of custom XML elements within the document.
/// </summary>
[DataContract]
[XmlRoot("MarkupEndRangeElement", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class MarkupEndRangeElement<T1, T2> : ModelElement<T1>, IMarkupElement where T1 : DX.OpenXmlElement where T2 : DX.OpenXmlElement
{
  /// <summary>
  /// Gets the element that forms the matching pair for this markup range element, if one exists.
  /// </summary>
  public MarkupStartRangeElement<T1, T2>? PairedElement { get => _PairedElement; set => UpdateField(ref _PairedElement, value, nameof(PairedElement)); }
  private MarkupStartRangeElement<T1, T2>? _PairedElement;
}