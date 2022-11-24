namespace DocumentModel.Office2019.Drawing.HyperLinkColor;

/// <summary>
/// Defines the HyperlinkColor Class.
/// </summary>
public interface IHyperlinkColor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2019 and later.
  /// </summary>
  public HyperlinkColorEnum? Val { get ; set; }
  
}
