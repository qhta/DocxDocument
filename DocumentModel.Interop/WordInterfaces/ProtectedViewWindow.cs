namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a protected view window.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow?view=word-pia"/>
public partial interface ProtectedViewWindow : InteropObject
{
  /// <summary>
  /// Returns or sets the caption.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Returns the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.document?view=word-pia"/>
  public Document Document { get; }

  /// <summary>
  /// Returns or sets the left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// Returns or sets the top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// Returns or sets the width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// Returns or sets the window state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.windowstate?view=word-pia"/>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// Returns whether active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// Returns the index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns or sets whether visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// Returns the source name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.sourcename?view=word-pia"/>
  public string SourceName { get; }

  /// <summary>
  /// Returns the source path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.sourcepath?view=word-pia"/>
  public string SourcePath { get; }
}
