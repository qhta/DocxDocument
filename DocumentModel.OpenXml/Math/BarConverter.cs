namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Bar"/> class from/to OpenXml converter.
/// </summary>
public static class BarConverter
{
  #region Bar Properties conversion.
  private static DMM.BarProperties? GetBarProperties(DXM.Bar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.BarProperties>();
    if (element != null)
      return DMXM.BarPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBarProperties(DXM.Bar openXmlElement, DMM.BarProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.BarPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.BarProperties>(), value, diffs, objName);
  }
  
  private static void SetBarProperties(DXM.Bar openXmlElement, DMM.BarProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BarProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BarPropertiesConverter.CreateOpenXmlElement<DXM.BarProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Argument conversion.
  private static DMM.Argument? GetArgument(DXM.Bar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Bar openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.Bar openXmlElement, DMM.Argument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ArgumentConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Bar model conversion.
  public static DMM.Bar? CreateModelElement(DXM.Bar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Bar();
      model.BarProperties = GetBarProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Bar? openXmlElement, DMM.Bar? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBarProperties(openXmlElement, model.BarProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Bar CreateOpenXmlElement(DMM.Bar model)
  {
    var openXmlElement = new DXM.Bar();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Bar openXmlElement, DMM.Bar model)
  {
    SetBarProperties(openXmlElement, model?.BarProperties);
    SetArgument(openXmlElement, model?.Argument);
    return true;
  }
  #endregion
}
