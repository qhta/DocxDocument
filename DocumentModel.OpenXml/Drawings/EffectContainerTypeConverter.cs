namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public static class EffectContainerTypeConverter
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  private static DMDraws.EffectContainerKind? GetType(DXDraw.EffectContainerType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMDraws.EffectContainerKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXDraw.EffectContainerType openXmlElement, DMDraws.EffectContainerKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMDraws.EffectContainerKind>(value);
  }
  
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.EffectContainerType openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDraw.EffectContainerType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  public static DMDraws.EffectContainerType? CreateModelElement(DXDraw.EffectContainerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.EffectContainerType();
      value.Type = GetType(openXmlElement);
      value.Name = GetName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectContainerType? value)
    where OpenXmlElementType: DXDraw.EffectContainerType, new()
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
