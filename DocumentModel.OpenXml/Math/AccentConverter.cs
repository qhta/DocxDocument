namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Accent"/> class from/to OpenXml converter.
/// </summary>
public static class AccentConverter
{
  #region Accent Properties conversion.
  private static DMM.AccentProperties? GetAccentProperties(DXM.Accent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.AccentProperties>();
    if (element != null)
      return DMXM.AccentPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAccentProperties(DXM.Accent openXmlElement, DMM.AccentProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.AccentPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.AccentProperties>(), value, diffs, objName);
  }
  
  private static void SetAccentProperties(DXM.Accent openXmlElement, DMM.AccentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.AccentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.AccentPropertiesConverter.CreateOpenXmlElement<DXM.AccentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.Accent openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Accent openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.Accent openXmlElement, DMM.Argument? value)
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

  #region Accent model conversion.
  public static DMM.Accent? CreateModelElement(DXM.Accent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Accent();
      model.AccentProperties = GetAccentProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Accent? openXmlElement, DMM.Accent? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAccentProperties(openXmlElement, model.AccentProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Accent CreateOpenXmlElement(DMM.Accent model)
  {
    var openXmlElement = new DXM.Accent();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Accent openXmlElement, DMM.Accent model)
  {
    SetAccentProperties(openXmlElement, model.AccentProperties);
    SetArgument(openXmlElement, model.Argument);
    return true;
  }
  #endregion
}
