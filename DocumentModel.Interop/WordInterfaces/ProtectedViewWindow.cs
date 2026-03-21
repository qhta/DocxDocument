namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a protected view window.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow?view=word-pia"/>
public partial interface ProtectedViewWindow : InteropObject
{
  /// <summary>
  /// The caption.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// The document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// The window state.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.windowstate?view=word-pia"/>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// The active.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// The source name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.sourcename?view=word-pia"/>
  public string SourceName { get; }

  /// <summary>
  /// The source path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.sourcepath?view=word-pia"/>
  public string SourcePath { get; }
}
