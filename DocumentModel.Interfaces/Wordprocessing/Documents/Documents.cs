namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of all the Document objects that are currently open in Word.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.documents?view=word-pia"/>
public partial interface IDocuments : IModelCollection<IDocument>
{
}
