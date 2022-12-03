namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkExtension Class.
/// </summary>
public interface HyperlinkExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public HyperlinkColorEnum? HyperlinkColor { get ; set; }
  
}
