namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CustomXmlElement"/> class from/to OpenXml converter.
/// </summary>
public static class CustomXmlElementConverter
{
  #region Uri conversion.
  private static String? GetUri(DXW.CustomXmlElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXW.CustomXmlElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXW.CustomXmlElement openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Element conversion.
  private static String? GetElement(DXW.CustomXmlElement openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Element);
  }
  
  private static bool CmpElement(DXW.CustomXmlElement openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Element, value, diffs, objName, "Element");
  }
  
  private static void SetElement(DXW.CustomXmlElement openXmlElement, String? value)
  {
    openXmlElement.Element = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region CustomXmlProperties conversion.
  private static DMW.CustomXmlProperties? GetCustomXmlProperties(DXW.CustomXmlElement openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.CustomXmlProperties>();
    if (element != null)
      return DMXW.CustomXmlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomXmlProperties(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.CustomXmlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.CustomXmlProperties>(), value, diffs, objName);
  }
  
  private static void SetCustomXmlProperties(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CustomXmlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CustomXmlPropertiesConverter.CreateOpenXmlElement<DXW.CustomXmlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region CustomXmlElement model conversion.
  public static ElementType? CreateModelElement<ElementType>(DXW.CustomXmlElement? openXmlElement)
    where ElementType : DMW.CustomXmlElement, new()
  {
    if (openXmlElement != null)
    {
      var model = new ElementType();
      model.Uri = GetUri(openXmlElement);
      model.Element = GetElement(openXmlElement);
      model.CustomXmlProperties = GetCustomXmlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CustomXmlElement? openXmlElement, DMW.CustomXmlElement? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, model.Uri, diffs, objName))
        ok = false;
      if (!CmpElement(openXmlElement, model.Element, diffs, objName))
        ok = false;
      if (!CmpCustomXmlProperties(openXmlElement, model.CustomXmlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CustomXmlElement model)
    where OpenXmlElementType: DXW.CustomXmlElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.CustomXmlElement openXmlElement, DMW.CustomXmlElement model)
  {
    SetUri(openXmlElement, model?.Uri);
    SetElement(openXmlElement, model?.Element);
    SetCustomXmlProperties(openXmlElement, model?.CustomXmlProperties);
  }
  #endregion
}
