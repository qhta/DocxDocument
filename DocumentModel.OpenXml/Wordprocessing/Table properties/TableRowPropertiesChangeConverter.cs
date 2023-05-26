namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableRowPropertiesChange"/> class from/to OpenXml converter.
/// </summary>
public static class TableRowPropertiesChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.TableRowPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TableRowPropertiesChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TableRowPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXW.TableRowPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.TableRowPropertiesChange openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.TableRowPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.TableRowPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TableRowPropertiesChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.TableRowPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Previous Table Row Properties conversion.
  private static DMW.PreviousTableRowProperties? GetPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableRowProperties>();
    if (element != null)
      return DMXW.PreviousTableRowPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableRowProperties(DXW.TableRowPropertiesChange openXmlElement, DMW.PreviousTableRowProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.PreviousTableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableRowProperties>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region TableRowPropertiesChange model conversion.
  public static DMW.TableRowPropertiesChange? CreateModelElement(DXW.TableRowPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableRowPropertiesChange();
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.AnnotationId = GetId(openXmlElement);
      model.PreviousTableRowProperties = GetPreviousTableRowProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableRowPropertiesChange? openXmlElement, DMW.TableRowPropertiesChange? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, model.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, model.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, model.AnnotationId, diffs, objName, propName))
        ok = false;
      if (!CmpPreviousTableRowProperties(openXmlElement, model.PreviousTableRowProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableRowPropertiesChange model)
    where OpenXmlElementType: DXW.TableRowPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableRowPropertiesChange openXmlElement, DMW.TableRowPropertiesChange model)
  {
    SetAuthor(openXmlElement, model?.Author);
    SetDate(openXmlElement, model?.Date);
    SetId(openXmlElement, model?.AnnotationId);
    SetPreviousTableRowProperties(openXmlElement, model?.PreviousTableRowProperties);
  }
  #endregion
}
