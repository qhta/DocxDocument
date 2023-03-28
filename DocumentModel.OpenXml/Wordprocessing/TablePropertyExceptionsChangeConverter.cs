namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions converter from/to OpenXml.
///</summary>
public static class TablePropertyExceptionsChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TablePropertyExceptionsChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TablePropertyExceptionsChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TablePropertyExceptionsChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TablePropertyExceptionsChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TablePropertyExceptionsChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.TablePropertyExceptionsChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  private static DMW.PreviousTablePropertyExceptions? GetPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
    if (element != null)
      return DMXW.PreviousTablePropertyExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement, DMW.PreviousTablePropertyExceptions? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTablePropertyExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTablePropertyExceptions>(), value, diffs, objName);
  }
  
  private static void SetPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement, DMW.PreviousTablePropertyExceptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTablePropertyExceptionsConverter.CreateOpenXmlElement<DXW.PreviousTablePropertyExceptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TablePropertyExceptionsChange? CreateModelElement(DXW.TablePropertyExceptionsChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePropertyExceptionsChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTablePropertyExceptions = GetPreviousTablePropertyExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePropertyExceptionsChange? openXmlElement, DMW.TablePropertyExceptionsChange? value, DiffList? diffs, string? objName)
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
      if (!CmpPreviousTablePropertyExceptions(openXmlElement, value.PreviousTablePropertyExceptions, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertyExceptionsChange value)
    where OpenXmlElementType: DXW.TablePropertyExceptionsChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TablePropertyExceptionsChange openXmlElement, DMW.TablePropertyExceptionsChange value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
    SetPreviousTablePropertyExceptions(openXmlElement, value?.PreviousTablePropertyExceptions);
  }
}
