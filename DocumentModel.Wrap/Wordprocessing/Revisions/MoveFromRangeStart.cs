namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the start of a region whose move source contents are part of a single named move. 
///   When a move source is stored as a revision in a WordprocessingML document, two pieces of information shall be stored about that move source:
///   <list type="bullet">
///     <item>
///       A set of pieces of content which were moved - both inline-level content (§17.13.5.22) and paragraphs (§17.13.5.21) 
///     </item>
///     <item>
///       A move source container (or "bookmark") which specifies that all content within it 
///       which marked as a move source is part of a single named move. The name attribute on the move container 
///       links a group of move source content with the corresponding group of move destination content. 
///     </item>
///   </list>
///   This element defines the start of the latter piece of the move revision data - the container. 
///   The Id attribute on this element shall be used to link this element 
///   with the corresponding end of a move source container in the document. 
/// </summary>
public class MoveFromRangeStart: MoveBookmarkType
{
}