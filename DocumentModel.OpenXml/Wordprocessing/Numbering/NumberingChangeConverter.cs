namespace DocumentModel.OpenXml.Wordprocessing;


/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumberingChange"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingChangeConverter
{

  #region original
  private static String? GetOriginal(DXW.NumberingChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Original);
  }

  private static bool CmpOriginal(DXW.NumberingChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Original, value, diffs, objName, "Original");
  }

  private static void SetOriginal(DXW.NumberingChange openXmlElement, String? value)
  {
    openXmlElement.Original = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region author
  private static String? GetAuthor(DXW.NumberingChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }

  private static bool CmpAuthor(DXW.NumberingChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }

  private static void SetAuthor(DXW.NumberingChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region date
  private static DateTime? GetDate(DXW.NumberingChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  private static bool CmpDate(DXW.NumberingChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }

  private static void SetDate(DXW.NumberingChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier
  private static String? GetId(DXW.NumberingChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }

  private static bool CmpId(DXW.NumberingChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }

  private static void SetId(DXW.NumberingChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region NumberingChange model conversion
  public static DMW.NumberingChange? CreateModelElement(DXW.NumberingChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumberingChange();
      model.Original = GetOriginal(openXmlElement);
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.Id = GetId(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.NumberingChange? openXmlElement, DMW.NumberingChange? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpOriginal(openXmlElement, model.Original, diffs, objName))
        ok = false;
      if (!CmpAuthor(openXmlElement, model.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, model.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, model.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingChange model)
    where OpenXmlElementType : DXW.NumberingChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.NumberingChange openXmlElement, DMW.NumberingChange model)
  {
    SetOriginal(openXmlElement, model?.Original);
    SetAuthor(openXmlElement, model?.Author);
    SetDate(openXmlElement, model?.Date);
    SetId(openXmlElement, model?.Id);
  }
  #endregion
}
