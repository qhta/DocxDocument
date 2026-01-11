using System.Runtime.Serialization;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the abstract MarkupRangeType interface for the following types: 
///   BookmarkStart, BookmarkEnd, 
///   CommentRangeStart, CommentRangeEnd, 
///   MoveFromRangeStart, MoveFromRangeEnd, 
///   MoveToRangeStart, MoveToRangeEnd.
/// </summary>

public interface MarkupRangeElement: MarkupElement, CommonContent
{
  
  /// <summary>
  ///   Specifies that the parent annotation's placement shall be directly linked 
  ///   with the location of the physical presentation of a custom XML element in the document. 
  ///   This element only has an effect when the custom XML element is block-level (i.e. surrounds an entire paragraph), 
  ///   as in this scenario the logical and physical placement of the annotation and custom XML element can differ. 
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }
}