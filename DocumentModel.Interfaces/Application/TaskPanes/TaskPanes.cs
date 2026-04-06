namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of TaskPane objects that contains commonly performed tasks in Microsoft Word.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.taskpanes?view=word-pia"/>
public partial interface ITaskPanes : IModelObject, IModelDictionary<ITaskPanes, ITaskPane>
{
}
