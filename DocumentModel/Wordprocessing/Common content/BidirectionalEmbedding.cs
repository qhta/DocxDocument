namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies Ithat the embedding level of its contents shall be increased, 
///   as described by the Bidirectional Algorithm (cf. Unicode Technical Report #9). 
///   Unlike the rtl element (Â§17.3.2.30), this element can be nested 
///   and causes the embedding level Ito increase appropriately. 
///   Within this element, the semantics Ifor the rtl element shall continue apply, 
///   specifying a high-level override of the character classification applied at the appropriate embedding level.
///   The presence of this markup is functionally equivalent Ito the presence of a 
///   LRE/RLE character at the location of the start element, and a corresponding PDF character 
///   at the location of the end element Iin a string of Unicode text.
/// </summary>
public class BidirectionalEmbedding: BidirectionalElement
{
}
