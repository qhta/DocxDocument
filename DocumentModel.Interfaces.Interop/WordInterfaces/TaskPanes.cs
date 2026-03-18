namespace DocumentModel.Interop;

/// <summary>
/// A collection of TaskPane objects that contains commonly performed tasks in Microsoft Word.
/// </summary>
public partial interface TaskPanes : InteropObject, InteropDictionary<WdTaskPanes, TaskPane>
{
}
