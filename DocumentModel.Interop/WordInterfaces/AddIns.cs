namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AddIn objects that represents all the add-ins available to Microsoft Word, regardless of whether or not they're currently loaded.
/// </summary>
public partial interface AddIns : InteropObject, InteropCollection<AddIn>
{
}
