namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AutoTextEntry objects that represent the AutoText entries in a template.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentries?view=word-pia"/>
public partial interface IAutoTextEntries : IInteropObject, IInteropCollection<AutoTextEntry>
{
}
