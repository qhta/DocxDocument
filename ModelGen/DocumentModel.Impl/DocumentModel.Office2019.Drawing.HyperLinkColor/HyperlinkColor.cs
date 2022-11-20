namespace DocumentModel.Office2019.Drawing.HyperLinkColor;

/// <summary>
/// Defines the HyperlinkColor Class.
/// </summary>
public class HyperlinkColor: IHyperlinkColor
{
  /// <summary>
  /// val, this property is only available in Office 2019 and later.
  /// </summary>
  public HyperlinkColorEnum? Val
  {
    get;
    set;
  }
  
}
