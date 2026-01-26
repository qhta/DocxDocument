namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a change to paragraph numbering properties in a WordprocessingML document.
/// This class extends <see cref = "IIdentifiedChange"/> and provides a property for the original numbering value, enabling tracking and management of revisions to paragraph numbering.
/// </summary>
[OpenXmlType(typeof(DXW.NumberingChange))]
public partial class NumberingChange : TrackChangeType<DXW.NumberingChange>
{
 /// <summary>
 /// Original numbering value before the change, used for comparison and revision tracking.
 /// </summary>
 public string? Original { get; set; }
}