namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a protected view window.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow?view=word-pia"/>
public partial interface IProtectedViewWindow : IModelObject
{
  /// <summary>
  /// Gets or sets the caption text that is displayed in the title bar of the document or protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// Gets a Document object associated with the protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.document?view=word-pia"/>
  public IDocument Document { get; }

  /// <summary>
  /// Gets or sets a value, in points, that represents the horizontal position of the specified protected view
  /// window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// Gets or sets the vertical position, in points, of the specified protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// Gets or sets the width, in points, of the specified protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Gets or sets the height of the protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// Gets or sets the state of the specified protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.windowstate?view=word-pia"/>
  public WindowState WindowState { get; set; }

  /// <summary>
  /// Gets whether the specified protected view window is active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// Returns a value that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets whether the specified protected view window is visible.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.visible?view=word-pia"/>
  public bool Visible { get; set; }

  /// <summary>
  /// Gets the name of the source file for the specified protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.sourcename?view=word-pia"/>
  public string SourceName { get; }

  /// <summary>
  /// Gets the path of the source file for the specified protected view window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindow.sourcepath?view=word-pia"/>
  public string SourcePath { get; }
}
