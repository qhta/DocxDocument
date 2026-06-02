namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of InlineShape objects that represent all the inline shapes in a document, range, or selection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.inlineshapes?view=word-pia"/>
public partial interface IInlineShapes : IInteropObject, IInteropCollection<InlineShape>
{
}
