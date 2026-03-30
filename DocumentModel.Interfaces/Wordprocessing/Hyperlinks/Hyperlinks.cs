namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the collection of Hyperlink objects in a document, range, or selection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlinks?view=word-pia"/>
public partial interface IHyperlinks : IModelCollection<IHyperlink>
{
}
