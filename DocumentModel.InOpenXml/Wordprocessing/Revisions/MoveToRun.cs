namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents inline-level content that has been moved to this location and tracked as a revision in a WordprocessingML document.
  /// This class extends <see cref="RunTrackChangeType"/> and is used to mark content as moved, enabling revision tracking and review of content relocations within the document.
  /// </summary>
  public class MoveToRun : RunTrackChangeType
  {
  }