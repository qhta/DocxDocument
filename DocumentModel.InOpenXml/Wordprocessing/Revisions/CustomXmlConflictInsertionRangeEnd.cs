namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the end of a custom XML conflict insertion range in a WordprocessingML document.
/// This class extends <see cref="MarkupRangeElement"/> and is used to mark the end of a region where custom XML content has been inserted in conflict with other changes, enabling revision tracking and review of conflicting custom XML insertions.
/// </summary>
public class CustomXmlConflictInsertionRangeEnd : 
  MarkupEndRangeElement<DXO10W.CustomXmlConflictInsertionRangeEnd, DXO10W.CustomXmlConflictInsertionRangeStart>
{
}