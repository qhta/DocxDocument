namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the start of a custom XML move-to range in a WordprocessingML document.
/// This class extends <see cref = "TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been moved to a new location as part of tracked changes, enabling revision tracking and review of custom XML moves.
/// </summary>
[OpenXmlType(typeof(DXW.CustomXmlMoveToRangeStart))]
public class CustomXmlMoveToRangeStart : MarkupStartRangeElement<DXW.CustomXmlMoveToRangeStart, DXW.CustomXmlMoveToRangeEnd>
{
}