namespace DocumentModel.Office2019.Drawing.HyperLinkColor;

/// <summary>
/// Defines the HyperlinkColor Class.
/// </summary>
public interface IHyperlinkColor // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2019 and later.
  /// </summary>
  public HyperlinkColorEnum? Val { get ; set; }
  
}
