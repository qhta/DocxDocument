namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a cell deletion track change in a WordprocessingML document.
/// This class extends <see cref = "TrackChangeType"/> and is used to indicate that a table cell has been deleted as part of tracked changes, enabling revision tracking and review of cell deletions in tables.
/// </summary>
[OpenXmlType(typeof(DXW.CellDeletion))]
public class CellDeletion : TrackChangeType<DXW.CellDeletion>
{
}