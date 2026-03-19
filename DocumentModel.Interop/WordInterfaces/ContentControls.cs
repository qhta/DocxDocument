namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ContentControl objects. Content controls are bounded and potentially labeled regions in a document that serve as containers for specific types of content. Individual content controls may contain content such as dates, lists, or paragraphs of formatted text.
/// </summary>
public partial interface ContentControls : InteropObject, InteropCollection<ContentControl>
{
}
