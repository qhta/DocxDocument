using System.Runtime.Serialization;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the abstract MarkupRangeType class for the following types: 
///   BookmarkStart, BookmarkEnd, 
///   CommentRangeStart, CommentRangeEnd, 
///   MoveFromRangeStart, MoveFromRangeEnd, 
///   MoveToRangeStart, MoveToRangeEnd.
/// </summary>
[KnownType(typeof(BookmarkStart))]
[KnownType(typeof(BookmarkEnd))]
[KnownType(typeof(CommentRangeStart))]
[KnownType(typeof(CommentRangeEnd))]
[KnownType(typeof(MoveFromRangeStart))]
[KnownType(typeof(MoveFromRangeEnd))]
[KnownType(typeof(MoveToRangeStart))]
[KnownType(typeof(MoveToRangeEnd))]
public abstract class MarkupRangeElement: ModelElement, IRangeMarkupElement, ICommonContent
{
  /// <summary>
  ///   Specifies a unique identifier for an annotation within a WordprocessingML document. 
  ///   The restrictions on the id attribute, if any, are defined by the parent XML element. 
  /// </summary>
  public Int32? Id { get; set; }
  
  /// <summary>
  ///   Specifies that the parent annotation's placement shall be directly linked 
  ///   with the location of the physical presentation of a custom XML element in the document. 
  ///   This element only has an effect when the custom XML element is block-level (i.e. surrounds an entire paragraph), 
  ///   as in this scenario the logical and physical placement of the annotation and custom XML element can differ. 
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }
}