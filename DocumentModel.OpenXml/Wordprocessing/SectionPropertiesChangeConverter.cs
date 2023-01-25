namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public static class SectionPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.SectionPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.SectionPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.SectionPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.SectionPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  private static DMW.PreviousSectionProperties? GetPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement)
  {
    return DMXW.PreviousSectionPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PreviousSectionProperties>());
  }
  
  private static bool CmpPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement, DMW.PreviousSectionProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousSectionPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousSectionProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SectionPropertiesChange? value)
    where OpenXmlElementType: DXW.SectionPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousSectionProperties(openXmlElement, value?.PreviousSectionProperties);
      return openXmlElement;
    }
    return default;
  }
}
