namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the end of a region whose move destination contents are part of a single named move in a WordprocessingML document.
/// This element defines the end of the move destination container (bookmark) for tracked move revisions. The Id attribute links this element with the corresponding start of the move destination container, grouping moved content for revision tracking and review.
/// </summary>
[OpenXmlType(typeof(DXW.MoveToRangeEnd))]
public class MoveToRangeEnd : MarkupEndRangeElement<DXW.MoveToRangeEnd, DXW.MoveToRangeStart>
{
}