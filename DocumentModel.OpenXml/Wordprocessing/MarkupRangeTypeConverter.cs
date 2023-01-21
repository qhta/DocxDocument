namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupRangeType Class.
/// </summary>
public static class MarkupRangeTypeConverter
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.MarkupRangeType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.MarkupRangeType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.MarkupRangeType? CreateModelElement(DXW.MarkupRangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MarkupRangeType();
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MarkupRangeType? value)
    where OpenXmlElementType: DXW.MarkupRangeType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
