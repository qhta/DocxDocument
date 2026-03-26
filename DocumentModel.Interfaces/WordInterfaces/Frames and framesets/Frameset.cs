namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an entire frames page or a single frame on a frames page.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset?view=word-pia"/>
public partial interface Frameset : InteropObject, InteropCollection<Frameset>
{
  /// <summary>
  /// Returns the parent frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.parentframeset?view=word-pia"/>
  public Frameset ParentFrameset { get; }

  /// <summary>
  /// Returns the type of the specified frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.type?view=word-pia"/>
  public FramesetType Type { get; }

  /// <summary>
  /// Returns or sets the way the width of the specified frameset is determined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.widthtype?view=word-pia"/>
  public FramesetSizeType WidthType { get; set; }

  /// <summary>
  /// Returns or sets the way the height of the specified frameset is determined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.heighttype?view=word-pia"/>
  public FramesetSizeType HeightType { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height of the specified frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// Returns the number of child framesets in the specified frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.childframesetcount?view=word-pia"/>
  public int ChildFramesetCount { get; }

  /// <summary>
  /// Returns or sets the width of the border around the specified frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetborderwidth?view=word-pia"/>
  public float FramesetBorderWidth { get; set; }

  /// <summary>
  /// Returns or sets the color of the border around the specified frameset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetbordercolor?view=word-pia"/>
  public RgbColor FramesetBorderColor { get; set; }

  /// <summary>
  /// Returns or sets how scroll bars are displayed for the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framescrollbartype?view=word-pia"/>
  public ScrollbarType FrameScrollbarType { get; set; }

  /// <summary>
  /// Determines whether the specified frame can be resized.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.frameresizable?view=word-pia"/>
  public bool FrameResizable { get; set; }

  /// <summary>
  /// Returns or sets the name of the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framename?view=word-pia"/>
  public string FrameName { get; set; }

  /// <summary>
  /// Determines whether borders are displayed for the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedisplayborders?view=word-pia"/>
  public bool FrameDisplayBorders { get; set; }

  /// <summary>
  /// Returns or sets the default URL for the specified frame.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedefaulturl?view=word-pia"/>
  public string FrameDefaultURL { get; set; }

  /// <summary>
  /// Determines whether the specified frame is linked to an external file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framelinktofile?view=word-pia"/>
  public bool FrameLinkToFile { get; set; }
}
