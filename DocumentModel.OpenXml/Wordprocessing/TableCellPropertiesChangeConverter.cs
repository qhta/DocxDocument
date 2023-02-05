namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public static class TableCellPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TableCellPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.TableCellPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Author?.Value == value) return true;
    diffs?.Add(objName, "Author", openXmlElement?.Author?.Value, value);
    return false;
  }
  
  private static void SetAuthor(DXW.TableCellPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TableCellPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TableCellPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TableCellPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TableCellPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.TableCellPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.TableCellPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  private static DMW.PreviousTableCellProperties? GetPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement)
  {
    return DMXW.PreviousTableCellPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PreviousTableCellProperties>());
  }
  
  private static bool CmpPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement, DMW.PreviousTableCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableCellProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement, DMW.PreviousTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTableCellPropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableCellPropertiesChange? CreateModelElement(DXW.TableCellPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableCellPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableCellProperties = GetPreviousTableCellProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellPropertiesChange? openXmlElement, DMW.TableCellPropertiesChange? value, DiffList? diffs, string? objName)
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
      if (!CmpPreviousTableCellProperties(openXmlElement, value.PreviousTableCellProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellPropertiesChange? value)
    where OpenXmlElementType: DXW.TableCellPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableCellProperties(openXmlElement, value?.PreviousTableCellProperties);
      return openXmlElement;
    }
    return default;
  }
}
