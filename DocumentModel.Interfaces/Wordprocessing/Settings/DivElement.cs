namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents information about a single HTML div element in a Wordprocessing document.
/// This interface provides properties for div identification, blockquote and body flags, margins, borders, and child div elements, enabling advanced configuration and management of HTML div structures within the document.
/// </summary>
public interface DivElement : CollectionItem
{
    
    /// <summary>
    /// Data ID for the HTML div element.
    /// </summary>
    public Int32? Id { get; set; }
    
    /// <summary>
    /// Indicates whether the div represents an HTML blockquote element.
    /// </summary>
    public bool? IsBlockQuote { get; set; }
    
    /// <summary>
    /// Indicates whether the div represents an HTML body element.
    /// </summary>
    public bool? IsBody { get; set; }
    
    /// <summary>
    /// Left margin for the HTML div element.
    /// </summary>
    public Twips? LeftMargin { get; set; }
    
    /// <summary>
    /// Right margin for the HTML div element.
    /// </summary>
    public Twips? RightMargin { get; set; }
    
    /// <summary>
    /// Top margin for the HTML div element.
    /// </summary>
    public Twips? TopMargin { get; set; }
    
    /// <summary>
    /// Bottom margin for the HTML div element.
    /// </summary>
    public Twips? BottomMargin { get; set; }
    
    /// <summary>
    /// Set of borders for the HTML div element.
    /// </summary>
    public DivBorders? DivBorder { get; set; }
    
    /// <summary>
    /// Collection of child div elements nested within this div.
    /// </summary>
    public DivCollection? Children { get; set; }
}