namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TaskPane objects that contains commonly performed tasks in Microsoft Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.taskpanes?view=word-pia"/>
public partial interface ITaskPanes : IInteropObject, IInteropDictionary<TaskPanes, TaskPane>
{
}
