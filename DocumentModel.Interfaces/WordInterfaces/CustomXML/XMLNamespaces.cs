namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of XMLNamespace objects that represents the entire collection of schemas in the Schema Library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces?view=word-pia"/>
public partial interface XMLNamespaces : InteropObject, InteropCollection<XMLNamespace>
{
}
