namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the page margin settings for a section in a Wordprocessing document.
/// This interface provides properties for top, right, bottom, left margins, header and footer spacing, and gutter spacing, enabling advanced configuration of page layout and printing options.
/// </summary>
public interface PageMargin : ISectionPropertiesContent
{
  
  /// <summary>
  /// Top margin spacing for the page.
  /// </summary>
  public Twips? Top { get; set; }
  
  /// <summary>
  /// Right margin spacing for the page.
  /// </summary>
  public Twips? Right { get; set; }
  
  /// <summary>
  /// Bottom margin spacing for the page.
  /// </summary>
  public Twips? Bottom { get; set; }
  
  /// <summary>
  /// Left margin spacing for the page.
  /// </summary>
  public Twips? Left { get; set; }
  
  /// <summary>
  /// Spacing to the top of the header.
  /// </summary>
  public Twips? Header { get; set; }
  
  /// <summary>
  /// Spacing to the bottom of the footer.
  /// </summary>
  public Twips? Footer { get; set; }
  
  /// <summary>
  /// Page gutter spacing, specifying additional space for binding.
  /// </summary>
  public Twips? Gutter { get; set; }
}