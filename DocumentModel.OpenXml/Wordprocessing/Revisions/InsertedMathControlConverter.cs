namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the InsertedMathControl Class.
/// </summary>
public static class InsertedMathControlConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.InsertedMathControl openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.InsertedMathControl openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.InsertedMathControl openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.InsertedMathControl openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.InsertedMathControl openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.InsertedMathControl openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.InsertedMathControl openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.InsertedMathControl openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.InsertedMathControl openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMW.RunProperties? GetRunProperties(DXW.InsertedMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunProperties>();
    if (element != null)
      return DMXW.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXW.InsertedMathControl openXmlElement, DMW.RunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetRunProperties(DXW.InsertedMathControl openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXW.InsertedMathControl openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DeletedMathControl>();
    if (element != null)
      return DMXW.DeletedMathControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDeletedMathControl(DXW.InsertedMathControl openXmlElement, DMW.DeletedMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DeletedMathControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DeletedMathControl>(), value, diffs, objName, propName);
  }
  
  private static void SetDeletedMathControl(DXW.InsertedMathControl openXmlElement, DMW.DeletedMathControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DeletedMathControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DeletedMathControlConverter.CreateOpenXmlElement<DXW.DeletedMathControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.InsertedMathControl? CreateModelElement(DXW.InsertedMathControl? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.InsertedMathControl();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      value.DeletedMathControl = GetDeletedMathControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.InsertedMathControl? openXmlElement, DMW.InsertedMathControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName, propName))
        ok = false;
      if (!CmpDeletedMathControl(openXmlElement, value.DeletedMathControl, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.InsertedMathControl value)
    where OpenXmlElementType: DXW.InsertedMathControl, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.InsertedMathControl openXmlElement, DMW.InsertedMathControl value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
  }
}
