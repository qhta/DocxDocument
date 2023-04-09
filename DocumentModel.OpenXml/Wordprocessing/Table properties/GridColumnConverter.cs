namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.GridColumn"/> class from/to OpenXml converter.
/// </summary>
public static class GridColumnConverter
{
  #region Grid Column Width conversion.
  private static DM.Twips? GetWidth(DXW.GridColumn openXmlElement)
  {
    return Int64ValueConverter.GetValue(openXmlElement?.Width);
  }
  
  private static bool CmpWidth(DXW.GridColumn openXmlElement, DM.Twips? value, DiffList? diffs, string? objName)
  {
    return Int64ValueConverter.CmpValue(openXmlElement?.Width, value, diffs, objName, "Value");
  }
  
  private static void SetWidth(DXW.GridColumn openXmlElement, DM.Twips? value)
  {
    openXmlElement.Width = Int64ValueConverter.CreateStringValue(value);
  }
  #endregion

  #region GridColumn model conversion.
  public static DMW.GridColumn? CreateModelElement(DXW.GridColumn? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.GridColumn();
      model.Width = GetWidth(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.GridColumn? openXmlElement, DMW.GridColumn? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpWidth(openXmlElement, model.Width, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.GridColumn model)
    where OpenXmlElementType: DXW.GridColumn, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.GridColumn openXmlElement, DMW.GridColumn model)
  {
    SetWidth(openXmlElement, model?.Width);
  }
  #endregion
}
