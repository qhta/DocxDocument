namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the start of a custom XML insertion range in a WordprocessingML document.
/// This class extends <see cref = "TrackChangeType"/> and is used to mark the beginning of a region where custom XML content has been inserted as part of tracked changes, enabling revision tracking and review of custom XML insertions.
/// </summary>
[OpenXmlType(typeof(DXW.CustomXmlInsRangeStart))]
public class CustomXmlInsRangeStart : MarkupStartRangeElement<DXW.CustomXmlInsRangeStart, DXW.CustomXmlInsRangeEnd>
{
}