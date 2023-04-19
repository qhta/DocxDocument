namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.BorderBox"/> class from/to OpenXml converter.
/// </summary>
public static class BorderBoxConverter
{
  #region Border Box Properties. conversion.
  private static DMM.BorderBoxProperties? GetBorderBoxProperties(DXM.BorderBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.BorderBoxProperties>();
    if (element != null)
      return DMXM.BorderBoxPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBorderBoxProperties(DXM.BorderBox openXmlElement, DMM.BorderBoxProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.BorderBoxPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.BorderBoxProperties>(), value, diffs, objName);
  }
  
  private static void SetBorderBoxProperties(DXM.BorderBox openXmlElement, DMM.BorderBoxProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.BorderBoxProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.BorderBoxPropertiesConverter.CreateOpenXmlElement<DXM.BorderBoxProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.BorderBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.BorderBox openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.BorderBox openXmlElement, DMM.Argument? value)
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

  #region BorderBox model conversion.
  public static DMM.BorderBox? CreateModelElement(DXM.BorderBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.BorderBox();
      model.BorderBoxProperties = GetBorderBoxProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.BorderBox? openXmlElement, DMM.BorderBox? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBorderBoxProperties(openXmlElement, model.BorderBoxProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.BorderBox CreateOpenXmlElement(DMM.BorderBox model)
  {
    var openXmlElement = new DXM.BorderBox();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.BorderBox openXmlElement, DMM.BorderBox model)
  {
    SetBorderBoxProperties(openXmlElement, model.BorderBoxProperties);
    SetArgument(openXmlElement, model.Argument);
    return true;
  }
  #endregion
}
