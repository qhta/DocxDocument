namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a tracked change in a WordprocessingML document, such as insertion, deletion, or modification.
/// This interface extends <see cref="MarkupRangeElement"/> and <see cref="CommonContent"/>, providing properties for author and date to enable revision tracking and review of document changes.
/// </summary>
public interface TrackChangeType : MarkupRangeElement, CommonContent
{
  
}