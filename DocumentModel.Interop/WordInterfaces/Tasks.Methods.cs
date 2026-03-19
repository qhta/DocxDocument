namespace DocumentModel.Interop.Word;

public partial interface Tasks
{
  /// <summary>
  /// Determines whether a task with the specified name exists.
  /// </summary>
  /// <param name="Name">The name of the task to check for existence.</param>
  /// <returns>true if the task exists; otherwise, false.</returns>
  public bool Exists(string Name);

  /// <summary>
  /// Closes all open applications, quits Microsoft Windows, and logs the current user off.
  /// </summary>
  public void ExitWindows();
}
