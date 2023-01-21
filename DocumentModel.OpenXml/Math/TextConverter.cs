namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Text.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// space
  /// </summary>
  private static DM.SpaceProcessingMode? GetSpace(DXMath.Text openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }
  
  private static void SetSpace(DXMath.Text openXmlElement, DM.SpaceProcessingMode? value)
  {
    openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DM.SpaceProcessingMode>(value);
  }
  
  public static DMMath.Text? CreateModelElement(DXMath.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Text();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Text? value)
    where OpenXmlElementType: DXMath.Text, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpace(openXmlElement, value?.Space);
      return openXmlElement;
    }
    return default;
  }
}
