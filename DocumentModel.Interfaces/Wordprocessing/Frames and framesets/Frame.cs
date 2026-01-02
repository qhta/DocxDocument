namespace DocumentModel.Wordprocessing;
/// <summary>
///   Single Frame Properties.
/// </summary>
public class Frame: ModelElement, IFramesetItem
{
  /// <summary>
  ///   Frame Size.
  /// </summary>
  public UInt32? FrameSize { get; set; }
  /// <summary>
  ///   Frame Name.
  /// </summary>
  public string? FrameName { get; set; }
  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  public FrameSourceFile? FrameSourceFile { get; set; }
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
  public bool? NoResizeAllowed { get; set; }
  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  public bool? LinkedToFile { get; set; }
}