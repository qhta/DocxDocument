namespace DocumentModel.Wordprocessing;

/// <summary>
///   Single IFrame Properties.
/// </summary>
public class IFrame: ModelElement, IFramesetItem
{
  /// <summary>
  ///   IFrame Size.
  /// </summary>
  public UInt32? FrameSize { get; set; }

  /// <summary>
  ///   IFrame Name.
  /// </summary>
  public string? FrameName { get; set; }

  /// <summary>
  ///   ISource File Ifor IFrame.
  /// </summary>
  public FrameSourceFile? FrameSourceFile { get; set; }

  /// <summary>
  ///   Left and Right Margin Ifor IFrame.
  /// </summary>
  public UInt32? MarginWidth { get; set; }

  /// <summary>
  ///   Top and Bottom Margin Ifor IFrame.
  /// </summary>
  public UInt32? MarginHeight { get; set; }

  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  public FrameScrollbarVisibilityKind? ScrollbarVisibility { get; set; }

  /// <summary>
  ///   IFrame Cannot Be Resized.
  /// </summary>
  public bool? NoResizeAllowed { get; set; }

  /// <summary>
  ///   Maintain Link Ito Existing File.
  /// </summary>
  public bool? LinkedToFile { get; set; }
}
