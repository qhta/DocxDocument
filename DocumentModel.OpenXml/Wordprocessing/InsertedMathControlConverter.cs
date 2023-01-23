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
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.InsertedMathControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.InsertedMathControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.InsertedMathControl openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static bool CmpDate(DXW.InsertedMathControl openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Date?.Value == value;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.InsertedMathControl openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.InsertedMathControl openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  private static DMW.RunProperties? GetRunProperties(DXW.InsertedMathControl openXmlElement)
  {
    return DMXW.RunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RunProperties>());
  }
  
  private static bool CmpRunProperties(DXW.InsertedMathControl openXmlElement, DMW.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunProperties(DXW.InsertedMathControl openXmlElement, DMW.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.DeletedMathControl? GetDeletedMathControl(DXW.InsertedMathControl openXmlElement)
  {
    return DMXW.DeletedMathControlConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.DeletedMathControl>());
  }
  
  private static bool CmpDeletedMathControl(DXW.InsertedMathControl openXmlElement, DMW.DeletedMathControl? value, DiffList? diffs, string? objName)
  {
    return DMXW.DeletedMathControlConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.DeletedMathControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
        openXmlElement.AddChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.InsertedMathControl? openXmlElement, DMW.InsertedMathControl? value, DiffList? diffs, string? objName)
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
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      if (!CmpDeletedMathControl(openXmlElement, value.DeletedMathControl, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.InsertedMathControl? value)
    where OpenXmlElementType: DXW.InsertedMathControl, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetDeletedMathControl(openXmlElement, value?.DeletedMathControl);
      return openXmlElement;
    }
    return default;
  }
}
