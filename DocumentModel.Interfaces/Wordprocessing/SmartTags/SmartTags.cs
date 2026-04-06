namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of SmartTag objects that represents the text in a document that is marked as containing
/// recognized type information.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttags?view=word-pia"/>
public partial interface ISmartTags : IModelCollection<ISmartTag>
{
}
