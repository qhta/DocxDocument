namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of page, column, or section breaks in a page. Use the Breaks collection and the related objects and properties to programmatically define page layout in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.breaks?view=word-pia"/>
public interface IBreaks : IModelCollection<IBreak>
{
}
