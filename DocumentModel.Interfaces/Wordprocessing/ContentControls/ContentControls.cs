namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of ContentControl objects. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain content such as dates, lists, or paragraphs of formatted text.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrols?view=word-pia"/>
public partial interface IContentControls : IModelCollection<IContentControl>
{
}
