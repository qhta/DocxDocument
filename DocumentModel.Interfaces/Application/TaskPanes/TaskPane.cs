namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single task pane available to Microsoft Word, which contains common tasks that users perform.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.taskpane?view=word-pia"/>
public interface ITaskPane : IModelObject
{
  /// <summary>
  /// Determines if the specified object is visible.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.taskpane.visible?view=word-pia"/>
  public bool Visible { get; set; }

}
