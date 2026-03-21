namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AddIn objects that represents all the add-ins available to Microsoft Word, regardless of whether or not they're currently loaded.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addins?view=word-pia"/>
public partial interface AddIns : InteropObject, InteropCollection<AddIn>
{
}
