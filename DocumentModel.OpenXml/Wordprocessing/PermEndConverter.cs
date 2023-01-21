namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public static class PermEndConverter
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  private static Int32? GetId(DXW.PermEnd openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXW.PermEnd openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.PermEnd openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DXW.PermEnd openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  public static DMW.PermEnd? CreateModelElement(DXW.PermEnd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PermEnd();
      value.Id = GetId(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PermEnd? value)
    where OpenXmlElementType: DXW.PermEnd, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      return openXmlElement;
    }
    return default;
  }
}
