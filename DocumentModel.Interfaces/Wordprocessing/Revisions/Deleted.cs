namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a deleted track change in a WordprocessingML document.
  /// This interface extends <see cref="TrackChangeType"/> and is used to indicate that content has been deleted as part of tracked changes, enabling revision tracking and review of content removals within the document.
  /// </summary>
  public interface Deleted : TrackChangeType
  {
  }