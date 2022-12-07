namespace DocumentModel.Drawings;

/// <summary>
/// Page Setup.
/// </summary>
public class PageSetup1Impl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.PageSetup>, PageSetup1
{
  /// <summary>
  /// Orientation
  /// </summary>
  public PageSetupOrientationKind? Orientation
  {
    get => (PageSetupOrientationKind?)OpenXmlElement?.Orientation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Orientation = (DocumentFormat.OpenXml.Drawing.Charts.PageSetupOrientationValues?)value;
    }
  }
  
}
