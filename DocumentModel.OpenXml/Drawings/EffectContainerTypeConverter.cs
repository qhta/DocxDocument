namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public static class EffectContainerTypeConverter
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public static DocumentModel.Drawings.EffectContainerKind? GetType(DocumentFormat.OpenXml.Drawing.EffectContainerType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DocumentModel.Drawings.EffectContainerKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Drawing.EffectContainerType? openXmlElement, DocumentModel.Drawings.EffectContainerKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DocumentModel.Drawings.EffectContainerKind>(value);
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.EffectContainerType? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.EffectContainerType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  public static DocumentModel.Drawings.EffectContainerType? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectContainerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectContainerType();
      value.Type = GetType(openXmlElement);
      value.Name = GetName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectContainerType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EffectContainerType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetName(openXmlElement, value?.Name);
      return openXmlElement;
    }
    return default;
  }
}
