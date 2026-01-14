namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a style (paragraph style, character style, etc.) in the document.
///   This interface provides properties for style name, type, base style, next paragraph style, update and visibility flags, paragraph and font formatting, and parent application, enabling advanced style management and formatting for document content.
/// </summary>
public interface Style: ICollectionItem
{
    
    /// <summary>
    /// Name of the style as defined in the document.
    /// </summary>
    public string? NameLocal { get; }
    
    /// <summary>
    /// Built-in style identifier, specifying the predefined style type.
    /// </summary>
    public BuiltInStyleKind? BuiltIn { get; }
    
    /// <summary>
    /// Type of style, such as paragraph, character, table, or numbering.
    /// </summary>
    public StyleKind? Type { get; }
    
    /// <summary>
    /// Base style on which this style is based, enabling inheritance of formatting.
    /// </summary>
    public Style? BaseStyle { get; }
    
    /// <summary>
    /// Next paragraph style to be applied after this style.
    /// </summary>
    public Style? NextParagraphStyle { get; }
    
    /// <summary>
    /// Indicates whether the style is automatically updated when formatting changes are made.
    /// </summary>
    public bool? AutomaticallyUpdate { get; set; }
    
    /// <summary>
    /// Indicates whether the style is hidden from the style gallery and UI.
    /// </summary>
    public bool? Hidden { get; set; }

}