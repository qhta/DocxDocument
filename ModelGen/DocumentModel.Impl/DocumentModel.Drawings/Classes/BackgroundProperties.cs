namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public class BackgroundPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>, BackgroundProperties
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Mode
  {
    get => (BlackWhiteMode?)OpenXmlElement?.Mode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Mode = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Pure
  {
    get => (BlackWhiteMode?)OpenXmlElement?.Pure?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pure = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public BlackWhiteMode? Normal
  {
    get => (BlackWhiteMode?)OpenXmlElement?.Normal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Normal = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public TargetScreenSize? TargetScreenSize
  {
    get => (TargetScreenSize?)OpenXmlElement?.TargetScreenSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TargetScreenSize = (DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize?)value;
    }
  }
  
}
