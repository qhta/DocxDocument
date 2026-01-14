namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a reference to a source file for a frame in a WordprocessingML document.
  /// This interface extends <see cref="ExternalFile"/> and is used to specify the external file that provides content for a frame, enabling advanced integration of external resources within document frames.
  /// </summary>
  public interface FrameSourceFile : ExternalFile
  {
  }
