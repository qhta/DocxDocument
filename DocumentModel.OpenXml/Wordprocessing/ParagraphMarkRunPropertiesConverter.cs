namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// ParagraphMarkRunProperties class from/to OpenXml converter
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
  
  private static bool CmpParagraphMarkRunPropertiesChange(DXW.ParagraphMarkRunProperties openXmlElement, DMW.ParagraphMarkRunPropertiesChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphMarkRunPropertiesChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphMarkRunPropertiesChange>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region ParagraphMarkRunProperties model conversion
  public static DMW.ParagraphMarkRunProperties? CreateModelElement(DXW.ParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphMarkRunProperties();
      ParagraphMarkRunPropertiesBaseConverter.UpdateModelElement(value, openXmlElement);
      value.ParagraphMarkRunPropertiesChange = GetParagraphMarkRunPropertiesChange(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphMarkRunProperties? openXmlElement, DMW.ParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!ParagraphMarkRunPropertiesBaseConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!CmpParagraphMarkRunPropertiesChange(openXmlElement, value.ParagraphMarkRunPropertiesChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphMarkRunProperties value)
    where OpenXmlElementType: DXW.ParagraphMarkRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ParagraphMarkRunProperties openXmlElement, DMW.ParagraphMarkRunProperties value)
  {
    ParagraphMarkRunPropertiesBaseConverter.UpdateOpenXmlElement(openXmlElement, value);
    SetParagraphMarkRunPropertiesChange(openXmlElement, value.ParagraphMarkRunPropertiesChange);
  }
  #endregion
}
