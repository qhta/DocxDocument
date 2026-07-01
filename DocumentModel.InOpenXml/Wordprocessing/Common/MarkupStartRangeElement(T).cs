using System.Runtime.Serialization;

namespace DocumentModel.Wordprocessing;
/// <summary>
///   Abstract base class for markup range start elements in a WordprocessingML document.
///   Implemented by types such as <see cref = "BookmarkStart"/>, <see cref = "CommentRangeStart"/>, <see cref = "MoveFromRangeStart"/>, and <see cref = "MoveToRangeStart"/>.
///   Provides properties for linking paired range elements, tracking annotation metadata, and managing the placement of custom XML elements within the document.
/// </summary>
[DataContract]
[XmlRoot("MarkupStartRangeElement", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class MarkupStartRangeElement<T1, T2> : ModelElement<T1>, IIdentifiedChange, IMarkupElement where T1 : DX.OpenXmlElement where T2 : DX.OpenXmlElement
{
  /// <summary>
  ///   Indicates that the parent annotation's placement is directly linked with the location of the physical presentation of a custom XML element in the document.
  ///   This property only has an effect when the custom XML element is block-level (i.e., surrounds an entire paragraph), as the logical and physical placement of the annotation and custom XML element can differ in this scenario.
  /// </summary>
  public DisplacedByCustomXml? DisplacedByCustomXml { get => _DisplacedByCustomXml; set => UpdateField(ref _DisplacedByCustomXml, value, nameof(DisplacedByCustomXml)); }
  private DisplacedByCustomXml? _DisplacedByCustomXml;

  /// <summary>
  ///   The element that forms the matching pair for this markup range start element, if one exists (e.g., the corresponding range end element).
  /// </summary>
  public MarkupEndRangeElement<T2, T1>? PairedElement { get => _PairedElement; set => UpdateField(ref _PairedElement, value, nameof(PairedElement)); }
  private MarkupEndRangeElement<T2, T1>? _PairedElement;

  /// <summary>
  ///   Unique identifier for the markup range, used to associate start and end elements and track changes.
  /// </summary>
  public int? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
  private int? _Id;

  /// <summary>
  ///   Name of the author or user who created or modified the markup range annotation.
  /// </summary>
  public string? Author { get => _Author; set => UpdateField(ref _Author, value, nameof(Author)); }
  private string? _Author;

  /// <summary>
  ///   Date and time when the markup range annotation was created or last modified.
  /// </summary>
  public DateTime? Date { get => _Date; set => UpdateField(ref _Date, value, nameof(Date)); }
  private DateTime? _Date;
}