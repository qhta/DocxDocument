namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of SmartTag objects that represents the text in a document that is marked as containing
/// recognized type information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags?view=word-pia"/>
public partial interface SmartTags : InteropObject, InteropCollection<SmartTag>
{
}
