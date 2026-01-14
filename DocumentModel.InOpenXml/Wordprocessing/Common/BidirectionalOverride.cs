namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a directional override applied according to the Unicode Bidirectional Algorithm (cf. Unicode Technical Report #9).
/// This class extends <see cref="IBidirectionalElement"/> and is functionally equivalent to using LRO/RLO and PDF characters in Unicode text, enabling advanced control of text directionality within document content.
/// </summary>
public interface BidirectionalOverride : IBidirectionalElement
{
}