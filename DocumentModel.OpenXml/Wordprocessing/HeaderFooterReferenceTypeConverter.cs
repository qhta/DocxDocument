namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class converter from/to OpenXml.
///</summary>
public static class HeaderFooterReferenceTypeConverter
{
  /// <summary>
  /// type
  /// </summary>
  private static DMW.HeaderFooterKind? GetType(DXW.HeaderFooterReferenceType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DMW.HeaderFooterKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXW.HeaderFooterReferenceType openXmlElement, DMW.HeaderFooterKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.HeaderFooterValues, DMW.HeaderFooterKind>(openXmlElement?.Type?.Value, value, diffs, objName);
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
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.HeaderFooterReferenceType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.HeaderFooterReferenceType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  private static ElementType? CreateModelElement<ElementType>(DXW.HeaderFooterReferenceType? openXmlElement)
    where ElementType: DMW.HeaderFooterReferenceType, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Type = GetType(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static DMW.HeaderReference? CreateModelElement(DXW.HeaderReference? openXmlElement)
    => CreateModelElement<DMW.HeaderReference>(openXmlElement);
  
  public static DMW.FooterReference? CreateModelElement(DXW.FooterReference? openXmlElement)
    => CreateModelElement<DMW.FooterReference>(openXmlElement);

  public static bool CompareModelElement(DXW.HeaderFooterReferenceType? openXmlElement, DMW.HeaderFooterReferenceType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.HeaderFooterReferenceType value)
    where OpenXmlElementType: DXW.HeaderFooterReferenceType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static DXW.HeaderReference CreateOpenXmlElement(DMW.HeaderReference openXmlElement)
    => CreateOpenXmlElement<DXW.HeaderReference>(openXmlElement);

  public static DXW.FooterReference CreateOpenXmlElement(DMW.FooterReference openXmlElement)
    => CreateOpenXmlElement<DXW.FooterReference>(openXmlElement);

  public static void UpdateOpenXmlElement(DXW.HeaderFooterReferenceType openXmlElement, DMW.HeaderFooterReferenceType value)
  {
    SetType(openXmlElement, value?.Type);
    SetId(openXmlElement, value?.Id);
  }
}
