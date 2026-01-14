namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the start of a region whose move destination contents are part of a single named move in a WordprocessingML document.
/// This element defines the start of the move destination container (bookmark) for tracked move revisions. The Id attribute links this element with the corresponding end of the move destination container, grouping moved content for revision tracking and review.
/// </summary>
public interface MoveToRangeStart : MoveBookmarkType
{
}