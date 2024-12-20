namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
public static class TablePropertyExceptionsChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TablePropertyExceptionsChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TablePropertyExceptionsChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TablePropertyExceptionsChange openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TablePropertyExceptionsChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TablePropertyExceptionsChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.TablePropertyExceptionsChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  private static DMW.PreviousTablePropertyExceptions? GetPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
    if (element != null)
      return DMXW.PreviousTablePropertyExceptionsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement, DMW.PreviousTablePropertyExceptions? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.PreviousTablePropertyExceptionsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTablePropertyExceptions>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMW.TablePropertyExceptionsChange? CreateModelElement(DXW.TablePropertyExceptionsChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePropertyExceptionsChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.AnnotationId = GetId(openXmlElement);
      value.PreviousTablePropertyExceptions = GetPreviousTablePropertyExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePropertyExceptionsChange? openXmlElement, DMW.TablePropertyExceptionsChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.AnnotationId, diffs, objName, propName))
        ok = false;
      if (!CmpPreviousTablePropertyExceptions(openXmlElement, value.PreviousTablePropertyExceptions, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
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
    SetId(openXmlElement, value?.AnnotationId);
    SetPreviousTablePropertyExceptions(openXmlElement, value?.PreviousTablePropertyExceptions);
  }
  #endregion
}
