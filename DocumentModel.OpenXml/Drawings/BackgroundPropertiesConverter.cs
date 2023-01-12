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
  
  public static DocumentModel.Drawings.BackgroundProperties? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundProperties();
      value.Mode = GetMode(openXmlElement);
      value.Pure = GetPure(openXmlElement);
      value.Normal = GetNormal(openXmlElement);
      value.TargetScreenSize = GetTargetScreenSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BackgroundProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMode(openXmlElement, value?.Mode);
      SetPure(openXmlElement, value?.Pure);
      SetNormal(openXmlElement, value?.Normal);
      SetTargetScreenSize(openXmlElement, value?.TargetScreenSize);
      return openXmlElement;
    }
    return default;
  }
}
