namespace DocumentModel.Wordprocessing.VBA;

/// <summary>
/// Represents a collection of macro data structures (Mcd) for VBA in a Wordprocessing document.
/// This interface provides access to and management of <see cref="Mcd"/> elements, enabling the storage and organization of supplementary macro-related data for VBA-enabled documents.
/// </summary>
public interface Mcds : ElementCollection<Mcd>
{
}