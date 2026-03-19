namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Task objects that represents all the tasks currently running on the system.
/// </summary>
public partial interface Tasks : InteropObject, InteropCollection<Task>
{
}
