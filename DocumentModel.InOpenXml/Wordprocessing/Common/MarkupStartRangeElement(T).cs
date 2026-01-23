using System.Runtime.Serialization;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the abstract class for markup range elements in a WordprocessingML document.
/// This class is implemented by types such as <see cref = "BookmarkStart"/>, <see cref = "BookmarkEnd"/>, <see cref = "CommentRangeStart"/>, <see cref = "CommentRangeEnd"/>, <see cref = "MoveFromRangeStart"/>, <see cref = "MoveFromRangeEnd"/>, <see cref = "MoveToRangeStart"/>, and <see cref = "MoveToRangeEnd"/>.
/// Provides properties for linking annotations and managing the placement of custom XML elements within the document.
/// </summary>
public abstract partial class MarkupStartRangeElement<T1, T2> : ModelElement<T1>, IIdentifiedChange, IMarkupElement where T1 : DX.OpenXmlElement where T2 : DX.OpenXmlElement
{
    /// <summary>
    /// Specifies that the parent annotation's placement is directly linked with the location of the physical presentation of a custom XML element in the document.
    /// This property only has an effect when the custom XML element is block-level (i.e., surrounds an entire paragraph), as the logical and physical placement of the annotation and custom XML element can differ in this scenario.
    /// </summary>
    public DisplacedByCustomXmlKind? DisplacedByCustomXml { get => _DisplacedByCustomXml; set => UpdateField(ref _DisplacedByCustomXml, value, nameof(DisplacedByCustomXml)); }

    private DisplacedByCustomXmlKind? _DisplacedByCustomXml;
    /// <summary>
    /// Gets the element that forms the matching pair for this markup range element, if one exists.
    /// </summary>
    public MarkupEndRangeElement<T2, T1>? PairedElement { get => _PairedElement; set => UpdateField(ref _PairedElement, value, nameof(PairedElement)); }

    private MarkupEndRangeElement<T2, T1>? _PairedElement;
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    public string? Author { get => _Author; set => UpdateField(ref _Author, value, nameof(Author)); }

    private string? _Author;
    public DateTime? Date { get => _Date; set => UpdateField(ref _Date, value, nameof(Date)); }

    private DateTime? _Date;
}