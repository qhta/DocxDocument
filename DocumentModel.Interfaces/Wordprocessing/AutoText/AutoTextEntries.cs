namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of AutoTextEntry objects that represent the AutoText entries in a template.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentries?view=word-pia"/>
public partial interface IAutoTextEntries : IModelCollection<IAutoTextEntry>
{
}
