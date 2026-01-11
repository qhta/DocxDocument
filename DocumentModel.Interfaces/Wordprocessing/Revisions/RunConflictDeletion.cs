namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents inline-level content that has been deleted in conflict with edits made by other users in a WordprocessingML document.
  /// This interface extends <see cref="RunTrackChangeType"/> and is used to mark content as a tracked deletion when conflicts occur, enabling revision tracking and review of conflicting inline deletions.
  /// </summary>
  public interface RunConflictDeletion : RunTrackChangeType
  {
  }