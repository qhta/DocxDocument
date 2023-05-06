namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Ruby"/> class from/to OpenXml converter.
/// </summary>
public static class RubyConverter
{
  #region RubyProperties conversion.
  private static DMW.RubyProperties? GetRubyProperties(DXW.Ruby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RubyProperties>();
    if (element != null)
      return DMXW.RubyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRubyProperties(DXW.Ruby openXmlElement, DMW.RubyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RubyProperties>(), value, diffs, objName);
  }
  
  private static void SetRubyProperties(DXW.Ruby openXmlElement, DMW.RubyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyPropertiesConverter.CreateOpenXmlElement<DXW.RubyProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region RubyContent conversion.
  private static DMW.RubyContent? GetRubyContent(DXW.Ruby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RubyContent>();
    if (element != null)
      return DMXW.RubyContentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRubyContent(DXW.Ruby openXmlElement, DMW.RubyContent? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyContentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RubyContent>(), value, diffs, objName);
  }
  
  private static void SetRubyContent(DXW.Ruby openXmlElement, DMW.RubyContent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyContent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyContentConverter.CreateOpenXmlElement<DXW.RubyContent>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region RubyBase conversion.
  private static DMW.RubyBase? GetRubyBase(DXW.Ruby openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RubyBase>();
    if (element != null)
      return DMXW.RubyBaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRubyBase(DXW.Ruby openXmlElement, DMW.RubyBase? value, DiffList? diffs, string? objName)
  {
    return DMXW.RubyBaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RubyBase>(), value, diffs, objName);
  }
  
  private static void SetRubyBase(DXW.Ruby openXmlElement, DMW.RubyBase? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RubyBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RubyBaseConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Ruby model conversion.
  public static DMW.Ruby? CreateModelElement(DXW.Ruby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Ruby();
      model.RubyProperties = GetRubyProperties(openXmlElement);
      model.RubyContent = GetRubyContent(openXmlElement);
      model.RubyBase = GetRubyBase(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Ruby? openXmlElement, DMW.Ruby? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRubyProperties(openXmlElement, model.RubyProperties, diffs, objName))
        ok = false;
      if (!CmpRubyContent(openXmlElement, model.RubyContent, diffs, objName))
        ok = false;
      if (!CmpRubyBase(openXmlElement, model.RubyBase, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.Ruby CreateOpenXmlElement(DMW.Ruby model)
  {
    var openXmlElement = new DXW.Ruby();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.Ruby openXmlElement, DMW.Ruby model)
  {
    SetRubyProperties(openXmlElement, model?.RubyProperties);
    SetRubyContent(openXmlElement, model?.RubyContent);
    SetRubyBase(openXmlElement, model?.RubyBase);
    return true;
  }
  #endregion
}
