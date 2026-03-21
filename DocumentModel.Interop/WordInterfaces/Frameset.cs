namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an entire frames page or a single frame on a frames page.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset?view=word-pia"/>
public partial interface Frameset : InteropObject, InteropCollection<Frameset>
{
  /// <summary>
  /// The parent frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.parentframeset?view=word-pia"/>
  public Frameset ParentFrameset { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.type?view=word-pia"/>
  public WdFramesetType Type { get; }

  /// <summary>
  /// The width type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.widthtype?view=word-pia"/>
  public WdFramesetSizeType WidthType { get; set; }

  /// <summary>
  /// The height type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.heighttype?view=word-pia"/>
  public WdFramesetSizeType HeightType { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// The child frameset count.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.childframesetcount?view=word-pia"/>
  public int ChildFramesetCount { get; }

  /// <summary>
  /// The frameset border width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetborderwidth?view=word-pia"/>
  public float FramesetBorderWidth { get; set; }

  /// <summary>
  /// The frameset border color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetbordercolor?view=word-pia"/>
  public WdColor FramesetBorderColor { get; set; }

  /// <summary>
  /// The frame scrollbar type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framescrollbartype?view=word-pia"/>
  public WdScrollbarType FrameScrollbarType { get; set; }

  /// <summary>
  /// The frame resizable.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.frameresizable?view=word-pia"/>
  public bool FrameResizable { get; set; }

  /// <summary>
  /// The frame name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framename?view=word-pia"/>
  public string FrameName { get; set; }

  /// <summary>
  /// The frame display borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedisplayborders?view=word-pia"/>
  public bool FrameDisplayBorders { get; set; }

  /// <summary>
  /// The frame default url.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedefaulturl?view=word-pia"/>
  public string FrameDefaultURL { get; set; }

  /// <summary>
  /// The frame link to file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framelinktofile?view=word-pia"/>
  public bool FrameLinkToFile { get; set; }
}
