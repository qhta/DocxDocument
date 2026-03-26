namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single task running on the system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task?view=word-pia"/>
public partial interface Task : InteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns or sets an Integer that represents the horizontal position of the specified task, measured in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.left?view=word-pia"/>
  public int Left { get; set; }

  /// <summary>
  /// Returns or sets the vertical position of the specified task, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.top?view=word-pia"/>
  public int Top { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.width?view=word-pia"/>
  public int Width { get; set; }

  /// <summary>
  /// Returns or sets the height of the specified task window, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.height?view=word-pia"/>
  public int Height { get; set; }

  /// <summary>
  /// Returns or sets the state of the specified task window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.windowstate?view=word-pia"/>
  public WindowState WindowState { get; set; }

  /// <summary>
  /// True if the specified object is visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.visible?view=word-pia"/>
  public bool Visible { get; set; }
}
