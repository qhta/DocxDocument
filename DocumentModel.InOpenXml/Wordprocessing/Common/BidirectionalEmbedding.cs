namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents an element that increases the embedding level of its contents according to the Unicode Bidirectional Algorithm (cf. Unicode Technical Report #9).
/// This class extends <see cref = "BidirectionalElement"/> and enables nested embedding levels, allowing for advanced control of bidirectional text layout. The semantics for the rtl element continue to apply within this element, providing high-level overrides of character classification at the appropriate embedding level. Functionally, this markup is equivalent to using LRE/RLE and PDF characters in Unicode text.
/// </summary>
[OpenXmlType(typeof(DXW.BidirectionalEmbedding))]
public class BidirectionalEmbedding : BidirectionalElement<DXW.BidirectionalEmbedding>
{
}