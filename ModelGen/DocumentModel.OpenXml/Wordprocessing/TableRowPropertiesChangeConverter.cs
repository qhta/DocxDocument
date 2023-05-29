namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public static class TableRowPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TableRowPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TableRowPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TableRowPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TableRowPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TableRowPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TableRowPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TableRowPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TableRowPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.TableRowPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Previous Table Row Properties.
  /// </summary>
  private static DMW.PreviousTableRowProperties? GetPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableRowProperties>();
    if (element != null)
      return DMXW.PreviousTableRowPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement, DMW.PreviousTableRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableRowProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement, DMW.PreviousTableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTableRowPropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableRowPropertiesChange? CreateModelElement(DXW.TableRowPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableRowPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableRowProperties = GetPreviousTableRowProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowPropertiesChange? openXmlElement, DMW.TableRowPropertiesChange? value, DiffList? diffs, string? objName)
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
      if (!CmpPreviousTableRowProperties(openXmlElement, value.PreviousTableRowProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowPropertiesChange value)
    where OpenXmlElementType: DXW.TableRowPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowPropertiesChange openXmlElement, DMW.TableRowPropertiesChange value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
    SetPreviousTableRowProperties(openXmlElement, value?.PreviousTableRowProperties);
  }
}
