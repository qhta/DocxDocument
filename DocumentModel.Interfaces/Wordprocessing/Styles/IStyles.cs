namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the collection of styles in a Wordprocessing document.
/// This interface provides access to document default paragraph and run properties, latent style information, and defined styles, enabling advanced style management and formatting for document content.
/// </summary>
public partial interface IStyles
{
    
    /// <summary>
    /// Document default paragraph and run properties, specifying default formatting for paragraphs and text runs.
    /// </summary>
    public DocDefaults? DocDefaults { get; set; }
    
    /// <summary>
    /// Latent style information, providing metadata and settings for latent styles in the document.
    /// </summary>
    public LatentStyles? LatentStyles { get; set; }
    
    /// <summary>
    /// Collection of defined styles in the document, including paragraph, character, table, and numbering styles.
    /// </summary>
    public DefinedStyles DefinedStyles { get; set; }
}