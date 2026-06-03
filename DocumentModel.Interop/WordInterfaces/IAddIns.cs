namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AddIn objects that represents all the add-ins available to Microsoft Word, regardless of whether or not they're currently loaded.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addins?view=word-pia"/>
public interface IAddIns : IInteropObject, IInteropCollection<IAddIn>
{
}
