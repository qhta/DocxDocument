namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties of a single frame in a WordprocessingML document.
/// This interface extends <see cref="FramesetItem"/> and provides properties for frame size, name, source file, margins, scrollbar visibility, resize restrictions, and file linking, enabling advanced configuration and management of frames within framesets.
/// </summary>
public interface Frame : FramesetItem
{
  
  /// <summary>
  /// Size of the frame, specified as a width or height value depending on the frameset orientation.
  /// </summary>
  public UInt32? FrameSize { get; set; }
  
  /// <summary>
  /// Name of the frame, used for identification and targeting within the frameset.
  /// </summary>
  public string? FrameName { get; set; }
  
  /// <summary>
  /// Source file for the frame, specifying the external content to be displayed within the frame.
  /// </summary>
  public FrameSourceFile? FrameSourceFile { get; set; }
  
  /// <summary>
  /// Left and right margin for the frame, specified in pixels.
  /// </summary>
  public UInt32? MarginWidth { get; set; }
  
  /// <summary>
  /// Top and bottom margin for the frame, specified in pixels.
  /// </summary>
  public UInt32? MarginHeight { get; set; }
  
  /// <summary>
  /// Scrollbar display option for the frame, specifying visibility and behavior of scrollbars.
  /// </summary>
  public FrameScrollbarVisibilityKind? ScrollbarVisibility { get; set; }
  
  /// <summary>
  /// Indicates whether the frame cannot be resized by the user.
  /// </summary>
  public bool? NoResizeAllowed { get; set; }
  
  /// <summary>
  /// Indicates whether the frame maintains a link to an existing external file.
  /// </summary>
  public bool? LinkedToFile { get; set; }
}