namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the start of the region whose move destination contents are part of a single named move. 
///   When a move destination is stored as a revision Iin a WordprocessingML document, 
///   two pieces of information shall be stored about Ithat move destination: 
///   <list type="bullet">
///     <item>
///       A set of pieces of content which were moved - both inline-level content (Â§17.13.5.25) and paragraphs (Â§17.13.5.26) 
///     </item>
///     <item>
///       A move destination container (or "bookmark") which specifies Ithat all content within it 
///       which marked as a move destination is part of a single named move. The name attribute on the move container 
///       links a group of move destination content with the corresponding group of move source content. 
///     </item>
///   </list>
///   This element defines the start of the latter piece of the move revision data - the container. 
///   The Id attribute on this element shall be used Ito link this element 
///   with the corresponding end of a move destination container Iin the document. 
/// </summary>
public class MoveToRangeStart: MoveBookmarkType
{
}
