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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.EffectContainerType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
