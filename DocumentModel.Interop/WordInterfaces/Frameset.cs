namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an entire frames page or a single frame on a frames page.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset?view=word-pia"/>
public partial interface Frameset : InteropObject, InteropCollection<Frameset>
{
  /// <summary>
/// Returns the parent frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.parentframeset?view=word-pia"/>
  public Frameset ParentFrameset { get; }

  /// <summary>
/// Returns the type of frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.type?view=word-pia"/>
  public WdFramesetType Type { get; }

  /// <summary>
/// Returns or sets the way a frame set width is specified.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.widthtype?view=word-pia"/>
  public WdFramesetSizeType WidthType { get; set; }

  /// <summary>
/// Returns or sets the way a frame set height is specified.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.heighttype?view=word-pia"/>
  public WdFramesetSizeType HeightType { get; set; }

  /// <summary>
/// Returns or sets the width of a frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
/// Returns or sets the height of a frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
/// Returns the number of child frame sets in a frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.childframesetcount?view=word-pia"/>
  public int ChildFramesetCount { get; }

  /// <summary>
/// Returns or sets the width of the border around a frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetborderwidth?view=word-pia"/>
  public float FramesetBorderWidth { get; set; }

  /// <summary>
/// Returns or sets the color of the border around a frame set.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetbordercolor?view=word-pia"/>
  public WdColor FramesetBorderColor { get; set; }

  /// <summary>
/// Returns or sets how scroll bars are displayed for a frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framescrollbartype?view=word-pia"/>
  public WdScrollbarType FrameScrollbarType { get; set; }

  /// <summary>
/// Returns or sets whether a frame can be resized.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.frameresizable?view=word-pia"/>
  public bool FrameResizable { get; set; }

  /// <summary>
/// Returns or sets the name of a frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framename?view=word-pia"/>
  public string FrameName { get; set; }

  /// <summary>
/// Returns or sets whether frame borders are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedisplayborders?view=word-pia"/>
  public bool FrameDisplayBorders { get; set; }

  /// <summary>
/// Returns or sets the URL that is loaded when a frame is opened.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedefaulturl?view=word-pia"/>
  public string FrameDefaultURL { get; set; }

  /// <summary>
/// Returns or sets whether a frame's content is linked to an external file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framelinktofile?view=word-pia"/>
  public bool FrameLinkToFile { get; set; }
}
