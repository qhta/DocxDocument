namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public static class HeaderFooterReferenceTypeConverter
{
  /// <summary>
  /// type
  /// </summary>
  private static DMW.HeaderFooterKind? GetType(DXW.HeaderFooterReferenceType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DMW.HeaderFooterKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.HeaderFooterReferenceType openXmlElement, DMW.HeaderFooterKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DMW.HeaderFooterKind>(value);
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DXW.HeaderFooterReferenceType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.HeaderFooterReferenceType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.HeaderFooterReferenceType? CreateModelElement(DXW.HeaderFooterReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.HeaderFooterReferenceType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.HeaderFooterReferenceType? value)
    where OpenXmlElementType: DXW.HeaderFooterReferenceType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
