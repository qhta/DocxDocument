namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundProperties Class.
/// </summary>
public static class BackgroundPropertiesConverter
{
  /// <summary>
  /// bwMode, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetMode(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.Mode?.Value);
  }
  
  public static void SetMode(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Mode = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// bwPure, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetPure(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.Pure?.Value);
  }
  
  public static void SetPure(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Pure = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// bwNormal, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.BlackWhiteMode? GetNormal(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(openXmlElement?.Normal?.Value);
  }
  
  public static void SetNormal(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement, DocumentModel.Drawings.BlackWhiteMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Normal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues, DocumentModel.Drawings.BlackWhiteMode>(value);
  }
  
  /// <summary>
  /// targetScreenSize, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.TargetScreenSize? GetTargetScreenSize(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DocumentModel.Drawings.TargetScreenSize>(openXmlElement?.TargetScreenSize?.Value);
  }
  
  public static void SetTargetScreenSize(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement, DocumentModel.Drawings.TargetScreenSize? value)
  {
    if (openXmlElement != null)
      openXmlElement.TargetScreenSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize, DocumentModel.Drawings.TargetScreenSize>(value);
  }
  
}
