namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the end of a region whose move source contents are part of a single named move in a WordprocessingML document.
///   This element defines the end of the move source container (bookmark) for tracked move revisions. The Id attribute links this element with the corresponding start of the move source container, grouping moved content for revision tracking and review.
/// </summary>
[OpenXmlType(typeof(DXW.MoveFromRangeEnd))]
public class MoveFromRangeEnd : MarkupStartRangeElement<DXW.MoveFromRangeEnd, DXW.MoveToRangeStart>
{
}