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
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.TableRowPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.TableRowPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TableRowPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TableRowPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Date?.Value == value;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.TableRowPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.TableRowPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Row Properties.
  /// </summary>
  private static DMW.PreviousTableRowProperties? GetPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement)
  {
    return DMXW.PreviousTableRowPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PreviousTableRowProperties>());
  }
  
  private static bool CmpPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement, DMW.PreviousTableRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableRowPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PreviousTableRowProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMW.TableRowPropertiesChange? CreateModelElement(DXW.TableRowPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableRowPropertiesChange();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowPropertiesChange? value)
    where OpenXmlElementType: DXW.TableRowPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableRowProperties(openXmlElement, value?.PreviousTableRowProperties);
      return openXmlElement;
    }
    return default;
  }
}
