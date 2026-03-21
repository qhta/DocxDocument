namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single task running on the system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task?view=word-pia"/>
public partial interface Task : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// The top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// The height.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// The window state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.windowstate?view=word-pia"/>
  public WdWindowState WindowState { get; set; }

  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.visible?view=word-pia"/>
  public bool Visible { get; set; }
}
