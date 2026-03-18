namespace DocumentModel.Interop;

/// <summary>
/// Represents an entire frames page or a single frame on a frames page.
/// </summary>
public partial interface Frameset : InteropObject, InteropCollection<Frameset>
{
  /// <summary>
  /// The parent frameset.
  /// </summary>
  public Frameset ParentFrameset { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdFramesetType Type { get; }

  /// <summary>
  /// The width type.
  /// </summary>
  public WdFramesetSizeType WidthType { get; set; }

  /// <summary>
  /// The height type.
  /// </summary>
  public WdFramesetSizeType HeightType { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public int Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  public int Height { get; set; }

  /// <summary>
  /// The child frameset count.
  /// </summary>
  public int ChildFramesetCount { get; }

  /// <summary>
  /// The frameset border width.
  /// </summary>
  public float FramesetBorderWidth { get; set; }

  /// <summary>
  /// The frameset border color.
  /// </summary>
  public WdColor FramesetBorderColor { get; set; }

  /// <summary>
  /// The frame scrollbar type.
  /// </summary>
  public WdScrollbarType FrameScrollbarType { get; set; }

  /// <summary>
  /// The frame resizable.
  /// </summary>
  public bool FrameResizable { get; set; }

  /// <summary>
  /// The frame name.
  /// </summary>
  public string FrameName { get; set; }

  /// <summary>
  /// The frame display borders.
  /// </summary>
  public bool FrameDisplayBorders { get; set; }

  /// <summary>
  /// The frame default url.
  /// </summary>
  public string FrameDefaultURL { get; set; }

  /// <summary>
  /// The frame link to file.
  /// </summary>
  public bool FrameLinkToFile { get; set; }
}
