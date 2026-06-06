namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Task objects that represents all the tasks currently running on the system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks?view=word-pia"/>
public interface ITasks : IInteropObject, IInteropCollection<Task>
{


  #region methods

/// <summary>
  /// Determines whether a task with the specified name exists.
  /// </summary>
  /// <param name="name">The name of the task to check for existence.</param>
  /// <returns>true if the task exists; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks.exists?view=word-pia"/>
  public bool Exists(string name);

  /// <summary>
  /// Closes all open applications, quits Microsoft Windows, and logs the current user off.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks.exitwindows?view=word-pia"/>
  public void ExitWindows();

  #endregion methods
}
