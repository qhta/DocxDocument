namespace DocumentModel.Wordprocessing;
/// <summary>
///   This element specifies the end of the region whose move destination contents are part of a single named move. 
///   When a move destination is stored as a revision in a WordprocessingML document, 
///   two pieces of information shall be stored about that move destination: 
///   <list type="bullet">
///     <item>
///       A set of pieces of content which were moved - both inline-level content (§17.13.5.25) and paragraphs (§17.13.5.26) 
///     </item>
///     <item>
///       A move destination container (or "bookmark") which specifies that all content within it 
///       which marked as a move destination is part of a single named move. The name attribute on the move container 
///       links a group of move destination content with the corresponding group of move source content. 
///     </item>
///   </list>
///   This element defines the end of the latter piece of the move revision data - the container. 
///   The Id attribute on this element shall be used to link this element 
///   with the corresponding start of a move destination container in the document. 
/// </summary>
public class MoveToRangeEnd: MarkupRangeElement
{
}