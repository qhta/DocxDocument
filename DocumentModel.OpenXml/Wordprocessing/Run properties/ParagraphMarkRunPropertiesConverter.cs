namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ParagraphMarkRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphMarkRunPropertiesConverter
{
  #region ParagraphMarkRunPropertiesChange conversion.
  private static DMW.ParagraphMarkRunPropertiesChange? GetParagraphMarkRunPropertiesChange(DXW.ParagraphMarkRunProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphMarkRunPropertiesChange>();
    if (element != null)
      return DMXW.ParagraphMarkRunPropertiesChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphMarkRunPropertiesChange(DXW.ParagraphMarkRunProperties openXmlElement, DMW.ParagraphMarkRunPropertiesChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.ParagraphMarkRunPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphMarkRunPropertiesChange>(), value, diffs, objName, propName);
  }
  
  private static void SetParagraphMarkRunPropertiesChange(DXW.ParagraphMarkRunProperties openXmlElement, DMW.ParagraphMarkRunPropertiesChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphMarkRunPropertiesChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphMarkRunPropertiesChangeConverter.CreateOpenXmlElement<DXW.ParagraphMarkRunPropertiesChange>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ParagraphMarkRunProperties model conversion.
  public static DMW.ParagraphMarkRunProperties? CreateModelElement(DXW.ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.ParagraphMarkRunProperties();
      ParagraphMarkRunPropertiesBaseConverter.UpdateModelElement(model, openXmlElement);
      model.ParagraphMarkRunPropertiesChange = GetParagraphMarkRunPropertiesChange(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphMarkRunProperties? openXmlElement, DMW.ParagraphMarkRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ParagraphMarkRunPropertiesBaseConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName))
        ok = false;
      if (!CmpParagraphMarkRunPropertiesChange(openXmlElement, model.ParagraphMarkRunPropertiesChange, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.ParagraphMarkRunProperties CreateOpenXmlElement(DMW.ParagraphMarkRunProperties model)
  {
    var openXmlElement = new DXW.ParagraphMarkRunProperties();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ParagraphMarkRunProperties openXmlElement, DMW.ParagraphMarkRunProperties model)
  {
    ParagraphMarkRunPropertiesBaseConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetParagraphMarkRunPropertiesChange(openXmlElement, model.ParagraphMarkRunPropertiesChange);
  }
  #endregion
}
