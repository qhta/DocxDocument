namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Task objects that represents all the tasks currently running on the system.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tasks?view=word-pia"/>
public partial interface ITasks : IInteropObject, IInteropCollection<Task>
{
}
