namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HyperlinkType Class.
/// </summary>
public class HyperlinkTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.HyperlinkType>, HyperlinkType
{
  /// <summary>
  /// Sound to play..
  /// </summary>
  public Boolean? HyperlinkSound
  {
    get;
    set;
  }
  
  /// <summary>
  /// Future extensions..
  /// </summary>
  public virtual HyperlinkExtensionList? HyperlinkExtensionList
  {
    get;
    set;
  }
  
}
