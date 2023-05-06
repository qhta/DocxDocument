namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.RunPropertiesChange"/> class from/to OpenXml converter.
/// </summary>
public static class RunPropertiesChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.RunPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.RunPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.RunPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region date conversion.
  private static DateTime? GetDate(DXW.RunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.RunPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.RunPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.RunPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.RunPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.RunPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region PreviousRunProperties conversion.
  private static DMW.PreviousRunProperties? GetPreviousRunProperties(DXW.RunPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousRunProperties>();
    if (element != null)
      return DMXW.PreviousRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousRunProperties(DXW.RunPropertiesChange openXmlElement, DMW.PreviousRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousRunProperties>(), value, diffs, objName);
  }
  
  private static void SetPreviousRunProperties(DXW.RunPropertiesChange openXmlElement, DMW.PreviousRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousRunPropertiesConverter.CreateOpenXmlElement<DXW.PreviousRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region RunPropertiesChange model conversion.
  public static DMW.RunPropertiesChange? CreateModelElement(DXW.RunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunPropertiesChange();
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.AnnotationId = GetId(openXmlElement);
      model.PreviousRunProperties = GetPreviousRunProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RunPropertiesChange? openXmlElement, DMW.RunPropertiesChange? model, DiffList? diffs, string? objName)
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
      if (!CmpPreviousRunProperties(openXmlElement, model.PreviousRunProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunPropertiesChange model)
    where OpenXmlElementType: DXW.RunPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RunPropertiesChange openXmlElement, DMW.RunPropertiesChange model)
  {
    SetAuthor(openXmlElement, model?.Author);
    SetDate(openXmlElement, model?.Date);
    SetId(openXmlElement, model?.AnnotationId);
    SetPreviousRunProperties(openXmlElement, model?.PreviousRunProperties);
  }
  #endregion
}
