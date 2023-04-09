namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TablePropertiesChange"/> class from/to OpenXml converter.
/// </summary>
public static class TablePropertiesChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.TablePropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.TablePropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.TablePropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
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
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.TablePropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.TablePropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.TablePropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Previous Table Properties conversion.
  private static DMW.PreviousTableProperties? GetPreviousTableProperties(DXW.TablePropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousTableProperties>();
    if (element != null)
      return DMXW.PreviousTablePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousTableProperties(DXW.TablePropertiesChange openXmlElement, DMW.PreviousTableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousTablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousTableProperties>(), value, diffs, objName);
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
  #endregion

  #region TablePropertiesChange model conversion.
  public static DMW.TablePropertiesChange? CreateModelElement(DXW.TablePropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TablePropertiesChange();
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.AnnotationId = GetId(openXmlElement);
      model.PreviousTableProperties = GetPreviousTableProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePropertiesChange? openXmlElement, DMW.TablePropertiesChange? model, DiffList? diffs, string? objName)
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
      if (!CmpPreviousTableProperties(openXmlElement, model.PreviousTableProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertiesChange model)
    where OpenXmlElementType: DXW.TablePropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TablePropertiesChange openXmlElement, DMW.TablePropertiesChange model)
  {
    SetAuthor(openXmlElement, model?.Author);
    SetDate(openXmlElement, model?.Date);
    SetId(openXmlElement, model?.AnnotationId);
    SetPreviousTableProperties(openXmlElement, model?.PreviousTableProperties);
  }
  #endregion
}
