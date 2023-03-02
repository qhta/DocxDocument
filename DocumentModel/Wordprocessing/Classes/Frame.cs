namespace DocumentModel.Wordprocessing;

/// <summary>
///   Single Frame Properties.
/// </summary>
public record Frame
{
  /// <summary>
  ///   Frame Size.
  /// </summary>
  public String? FrameSize { get; set; }

  /// <summary>
  ///   Frame Name.
  /// </summary>
  public String? FrameName { get; set; }

  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  public RelationshipType? SourceFileReference { get; set; }

  /// <summary>
  ///   Left and Right Margin for Frame.
  /// </summary>
  public UInt32? MarginWidth { get; set; }

  /// <summary>
  ///   Top and Bottom Margin for Frame.
  /// </summary>
  public UInt32? MarginHeight { get; set; }

  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  public FrameScrollbarVisibilityKind? ScrollbarVisibility { get; set; }

  /// <summary>
  ///   Frame Cannot Be Resized.
  /// </summary>
  public Boolean? NoResizeAllowed { get; set; }

  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  public Boolean? LinkedToFile { get; set; }
}