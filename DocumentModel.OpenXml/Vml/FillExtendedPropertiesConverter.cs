namespace DocumentModel.OpenXml.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public static class FillExtendedPropertiesConverter
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  private static DMVml.ExtensionHandlingBehaviorKind? GetExtension(DXVmlO.FillExtendedProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(openXmlElement?.Extension?.Value);
  }
  
  private static void SetExtension(DXVmlO.FillExtendedProperties openXmlElement, DMVml.ExtensionHandlingBehaviorKind? value)
  {
    openXmlElement.Extension = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues, DMVml.ExtensionHandlingBehaviorKind>(value);
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  private static DMVml.FillKind? GetType(DXVmlO.FillExtendedProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DMVml.FillKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXVmlO.FillExtendedProperties openXmlElement, DMVml.FillKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Vml.Office.FillValues, DMVml.FillKind>(value);
  }
  
  public static DMVml.FillExtendedProperties? CreateModelElement(DXVmlO.FillExtendedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMVml.FillExtendedProperties();
      value.Extension = GetExtension(openXmlElement);
      value.Type = GetType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMVml.FillExtendedProperties? value)
    where OpenXmlElementType: DXVmlO.FillExtendedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension(openXmlElement, value?.Extension);
      SetType(openXmlElement, value?.Type);
      return openXmlElement;
    }
    return default;
  }
}
