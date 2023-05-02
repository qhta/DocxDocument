namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a directional override, which shall be applied as described 
///   by the Bidirectional Algorithm (cf. Unicode Technical Report #9). 
///   The presence of this markup is functionally equivalent to the presence of a LRO/RLO character 
///   at the location of the start element, and a corresponding PDF character at the location of the end element 
///   in a string of Unicode text. 
/// </summary>
public class BidirectionalOverride: BidirectionalElement
{
}