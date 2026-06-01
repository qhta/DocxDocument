namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks?view=word-pia"/>
public partial class Tasks
{
  /// <summary>
  /// Determines whether a task with the specified name exists.
  /// </summary>
  /// <param name="Name">The name of the task to check for existence.</param>
  /// <returns>true if the task exists; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks.exists?view=word-pia"/>
  public bool Exists(string Name) { throw new NotImplementedException(); }

  /// <summary>
  /// Closes all open applications, quits Microsoft Windows, and logs the current user off.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks.exitwindows?view=word-pia"/>
  public void ExitWindows() { throw new NotImplementedException(); }
}
