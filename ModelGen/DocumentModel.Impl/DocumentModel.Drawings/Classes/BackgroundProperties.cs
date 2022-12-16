namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public class BackgroundPropertiesImpl: ModelElementImpl, BackgroundProperties
{
  public DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundPropertiesImpl(): base() {}
  
  public BackgroundPropertiesImpl(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? Mode
  {
    get => (DocumentModel.Drawings.BlackWhiteMode?)OpenXmlElement?.Mode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Mode = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? Pure
  {
    get => (DocumentModel.Drawings.BlackWhiteMode?)OpenXmlElement?.Pure?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pure = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? Normal
  {
    get => (DocumentModel.Drawings.BlackWhiteMode?)OpenXmlElement?.Normal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Normal = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawings.TargetScreenSize? TargetScreenSize
  {
    get => (DocumentModel.Drawings.TargetScreenSize?)OpenXmlElement?.TargetScreenSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TargetScreenSize = (DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize?)value;
    }
  }
  
}
