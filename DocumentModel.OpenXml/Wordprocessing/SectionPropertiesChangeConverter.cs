namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties converter from/to OpenXml.
///</summary>
public static class SectionPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.SectionPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.SectionPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.SectionPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.SectionPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.SectionPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.SectionPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.SectionPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.SectionPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  private static DMW.PreviousSectionProperties? GetPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousSectionProperties>();
    if (element != null)
      return DMXW.PreviousSectionPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement, DMW.PreviousSectionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousSectionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousSectionProperties>(), value, diffs, objName);
  }
  
  private static void SetPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement, DMW.PreviousSectionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousSectionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousSectionPropertiesConverter.CreateOpenXmlElement<DXW.PreviousSectionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SectionPropertiesChange? CreateModelElement(DXW.SectionPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SectionPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousSectionProperties = GetPreviousSectionProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SectionPropertiesChange? openXmlElement, DMW.SectionPropertiesChange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpPreviousSectionProperties(openXmlElement, value.PreviousSectionProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SectionPropertiesChange value)
    where OpenXmlElementType: DXW.SectionPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SectionPropertiesChange openXmlElement, DMW.SectionPropertiesChange value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
    SetPreviousSectionProperties(openXmlElement, value?.PreviousSectionProperties);
  }
}
