namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an entire frames page or a single frame on a frames page.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset?view=word-pia"/>
public partial interface IFrameset : IModelCollection<IFrameset>
{
  /// <summary>
  /// Returns the parent frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.parentframeset?view=word-pia"/>
  public IFrameset ParentFrameset { get; }

  /// <summary>
  /// Returns the type of the specified frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.type?view=word-pia"/>
  public FramesetType Type { get; }

  /// <summary>
  /// Returns or sets the way the width of the specified frameset is determined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.widthtype?view=word-pia"/>
  public FramesetSizeType WidthType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the way the height of the specified frameset is determined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.heighttype?view=word-pia"/>
  public FramesetSizeType HeightType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the width of the specified frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.width?view=word-pia"/>
  public int Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the height of the specified frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.height?view=word-pia"/>
  public int Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the number of child framesets in the specified frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.childframesetcount?view=word-pia"/>
  public int ChildFramesetCount { get; }

  /// <summary>
  /// Returns or sets the width of the border around the specified frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetborderwidth?view=word-pia"/>
  public float FramesetBorderWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the color of the border around the specified frameset.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framesetbordercolor?view=word-pia"/>
  public IColor FramesetBorderColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets how scroll bars are displayed for the specified frame.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framescrollbartype?view=word-pia"/>
  public ScrollbarType FrameScrollbarType { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines whether the specified frame can be resized.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.frameresizable?view=word-pia"/>
  public bool FrameResizable { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the name of the specified frame.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framename?view=word-pia"/>
  public string FrameName { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines whether borders are displayed for the specified frame.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedisplayborders?view=word-pia"/>
  public bool FrameDisplayBorders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the default URL for the specified frame.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framedefaulturl?view=word-pia"/>
  public string FrameDefaultURL { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines whether the specified frame is linked to an external file.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.frameset.framelinktofile?view=word-pia"/>
  public bool FrameLinkToFile { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
