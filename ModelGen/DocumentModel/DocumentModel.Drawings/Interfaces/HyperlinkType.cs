namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public interface HyperlinkType
{
  /// <summary>
  /// Sound to play..
  /// </summary>
  public Boolean? HyperlinkSound { get ; set; }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public HyperlinkExtensionList? HyperlinkExtensionList { get ; set; }
  
}
