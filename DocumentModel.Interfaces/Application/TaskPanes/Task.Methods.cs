namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task?view=word-pia"/>
public partial interface ITask: IModelObject
{
  /// <summary>
  /// Activates the task, optionally waiting for completion.
  /// </summary>
  /// <param name="Wait">true to wait for the task to activate; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.task.activate?view=word-pia"/>
  public void Activate(object Wait);
}
