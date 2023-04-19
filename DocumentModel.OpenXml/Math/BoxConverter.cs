namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Box"/> class from/to OpenXml converter.
/// </summary>
public static class BoxConverter
{
  #region Box Properties. conversion.
  private static DMM.BoxProperties? GetBoxProperties(DXM.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.BoxProperties>();
    if (element != null)
      return DMXM.BoxPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBoxProperties(DXM.Box openXmlElement, DMM.BoxProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.BoxPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.BoxProperties>(), value, diffs, objName);
  }
  
  private static void SetBoxProperties(DXM.Box openXmlElement, DMM.BoxProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BoxProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BoxPropertiesConverter.CreateOpenXmlElement<DXM.BoxProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Box openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.Box openXmlElement, DMM.Argument? value)
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

  #region Box model conversion.
  public static DMM.Box? CreateModelElement(DXM.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Box();
      model.BoxProperties = GetBoxProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Box? openXmlElement, DMM.Box? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBoxProperties(openXmlElement, model.BoxProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Box CreateOpenXmlElement(DMM.Box model)
  {
    var openXmlElement = new DXM.Box();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Box openXmlElement, DMM.Box model)
  {
    SetBoxProperties(openXmlElement, model?.BoxProperties);
    SetArgument(openXmlElement, model?.Argument);
    return true;
  }
  #endregion
}
