using System.Runtime.Serialization;
namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Defines the abstract interface for markup range elements in a WordprocessingML document.
  /// This interface is implemented by types such as <see cref="BookmarkStart"/>, <see cref="BookmarkEnd"/>, <see cref="CommentRangeStart"/>, <see cref="CommentRangeEnd"/>, <see cref="MoveFromRangeStart"/>, <see cref="MoveFromRangeEnd"/>, <see cref="MoveToRangeStart"/>, and <see cref="MoveToRangeEnd"/>.
  /// Provides properties for linking annotations and managing the placement of custom XML elements within the document.
  /// </summary>
  public interface MarkupRangeElement : MarkupElement
  {
    
    /// <summary>
    /// Specifies that the parent annotation's placement is directly linked with the location of the physical presentation of a custom XML element in the document.
    /// This property only has an effect when the custom XML element is block-level (i.e., surrounds an entire paragraph), as the logical and physical placement of the annotation and custom XML element can differ in this scenario.
    /// </summary>
    public DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }

    /// <summary>
    /// Gets the element that forms the matching pair for this markup range element, if one exists.
    /// </summary>
    public MarkupRangeElement PairedElement { get; }

  }