namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
public static class TablePropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.TablePropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.TablePropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TablePropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TablePropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.TablePropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.TablePropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Properties.
  /// </summary>
  private static DMW.PreviousTableProperties? GetPreviousTableProperties(DXW.TablePropertiesChange openXmlElement)
  {
    return DMXW.PreviousTablePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PreviousTableProperties>());
  }
  
  private static bool CmpPreviousTableProperties(DXW.TablePropertiesChange openXmlElement, DMW.PreviousTableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreviousTableProperties(DXW.TablePropertiesChange openXmlElement, DMW.PreviousTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTablePropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TablePropertiesChange? CreateModelElement(DXW.TablePropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableProperties = GetPreviousTableProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePropertiesChange? openXmlElement, DMW.TablePropertiesChange? value, DiffList? diffs, string? objName)
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
      if (!CmpPreviousTableProperties(openXmlElement, value.PreviousTableProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertiesChange? value)
    where OpenXmlElementType: DXW.TablePropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableProperties(openXmlElement, value?.PreviousTableProperties);
      return openXmlElement;
    }
    return default;
  }
}
