namespace DocumentModel.Wordprocessing;

/// <summary>
/// Embedded fonts stored in the document.
/// </summary>
[XmlObject]
public class EmbedFontData: Dictionary<string, byte[]>
{
}
