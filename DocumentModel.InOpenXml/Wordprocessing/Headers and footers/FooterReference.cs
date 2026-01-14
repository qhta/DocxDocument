namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference to a section footer in a WordprocessingML document.
/// This interface extends <see cref="HeaderFooterReferenceType"/> and is used to associate a section with a specific footer, enabling advanced management and referencing of footers for different sections and page types.
/// </summary>
public interface FooterReference : HeaderFooterReferenceType
{
}