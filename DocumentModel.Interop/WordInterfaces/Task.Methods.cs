namespace DocumentModel.Interop;

public partial interface Task
{
  /// <summary>
  /// Activates the task, optionally waiting for completion.
  /// </summary>
  /// <param name="Wait">true to wait for the task to activate; otherwise, false.</param>
  public void Activate(object Wait);
}
