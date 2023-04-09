namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableCellPropertiesChange"/> class from/to OpenXml converter./// </summary>
public static class TableCellPropertiesChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.TableCellPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TableCellPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TableCellPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
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
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.TableCellPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TableCellPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.TableCellPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region PreviousTableCellProperties conversion.
  private static DMW.PreviousTableCellProperties? GetPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableCellProperties>();
    if (element != null)
      return DMXW.PreviousTableCellPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableCellProperties(DXW.TableCellPropertiesChange openXmlElement, DMW.PreviousTableCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableCellProperties>(), value, diffs, objName);
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
  #endregion

  #region TableCellPropertiesChange conversion model conversion.
  public static DMW.TableCellPropertiesChange? CreateModelElement(DXW.TableCellPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableCellPropertiesChange();
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.AnnotationId = GetId(openXmlElement);
      model.PreviousTableCellProperties = GetPreviousTableCellProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableCellPropertiesChange? openXmlElement, DMW.TableCellPropertiesChange? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, model.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, model.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, model.AnnotationId, diffs, objName))
        ok = false;
      if (!CmpPreviousTableCellProperties(openXmlElement, model.PreviousTableCellProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableCellPropertiesChange model)
    where OpenXmlElementType: DXW.TableCellPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableCellPropertiesChange openXmlElement, DMW.TableCellPropertiesChange model)
  {
    SetAuthor(openXmlElement, model?.Author);
    SetDate(openXmlElement, model?.Date);
    SetId(openXmlElement, model?.AnnotationId);
    SetPreviousTableCellProperties(openXmlElement, model?.PreviousTableCellProperties);
  }
  #endregion
}
