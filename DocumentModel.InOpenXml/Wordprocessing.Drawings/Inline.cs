namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
///   Represents an inline shape (picture, diagram, etc.) within the text flow.
/// </summary>
/// <remarks>
///   Inline shapes flow with surrounding text like characters, as opposed to
///   floating shapes which can be positioned independently.
/// </remarks>
[OpenXmlType(typeof(DXDW.Inline))]
public partial class Inline: ModelElement<DXDW.Inline>
{
}