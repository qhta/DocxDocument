namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of stylistic sets in a Wordprocessing document.
/// This class provides access to and management of <see cref = "StyleSet"/> elements, enabling advanced configuration and organization of stylistic sets for document formatting.
/// </summary>
[OpenXmlType(typeof(StyleSet))]
public class StylisticSets : ModelElementCollection<StyleSet, DXO10W.StylisticSets, DXO10W.StyleSet>
{
}