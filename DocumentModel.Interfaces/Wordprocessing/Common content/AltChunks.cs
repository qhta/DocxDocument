namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a collection of alternative content chunks (AltChunk) in a Wordprocessing document.
/// This interface provides access to and management of <see cref="AltChunk"/> elements, enabling the inclusion of external content such as HTML, RTF, or other document fragments within the main document structure.
/// </summary>
public interface AltChunks : ElementCollection<AltChunk>
{
    
}