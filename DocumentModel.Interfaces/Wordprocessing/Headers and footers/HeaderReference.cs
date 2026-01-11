namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference to a section header in a WordprocessingML document.
/// This interface extends <see cref="HeaderFooterReferenceType"/> and is used to associate a section with a specific header, enabling advanced management and referencing of headers for different sections and page types.
/// </summary>
public interface HeaderReference : HeaderFooterReferenceType
{
}