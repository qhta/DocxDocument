namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.PreSubSuper"/> class from/to OpenXml converter.
/// </summary>
public static class PreSubSuperConverter
{
  #region Pre-Sub-Superscript Properties. conversion.
  private static DMM.PreSubSuperProperties? GetPreSubSuperProperties(DXM.PreSubSuper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.PreSubSuperProperties>();
    if (element != null)
      return DMXM.PreSubSuperPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreSubSuperProperties(DXM.PreSubSuper openXmlElement, DMM.PreSubSuperProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.PreSubSuperPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.PreSubSuperProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetPreSubSuperProperties(DXM.PreSubSuper openXmlElement, DMM.PreSubSuperProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.PreSubSuperProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.PreSubSuperPropertiesConverter.CreateOpenXmlElement<DXM.PreSubSuperProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Subscript (Pre-Sub-Superscript) conversion.
  private static DMM.SubArgument? GetSubArgument(DXM.PreSubSuper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubArgument>();
    if (element != null)
      return DMXM.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXM.PreSubSuper openXmlElement, DMM.SubArgument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubArgument>(), value, diffs, objName, propName);
  }
  
  private static void SetSubArgument(DXM.PreSubSuper openXmlElement, DMM.SubArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SubArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SubArgumentConverter.CreateOpenXmlElement<DXM.SubArgument>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Superscript(Pre-Sub-Superscript function) conversion.
  private static DMM.SuperArgument? GetSuperArgument(DXM.PreSubSuper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SuperArgument>();
    if (element != null)
      return DMXM.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXM.PreSubSuper openXmlElement, DMM.SuperArgument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SuperArgument>(), value, diffs, objName, propName);
  }
  
  private static void SetSuperArgument(DXM.PreSubSuper openXmlElement, DMM.SuperArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SuperArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SuperArgumentConverter.CreateOpenXmlElement<DXM.SuperArgument>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.PreSubSuper openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.PreSubSuper openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.PreSubSuper openXmlElement, DMM.Argument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ArgumentConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region PreSubSuper model conversion.
  public static DMM.PreSubSuper? CreateModelElement(DXM.PreSubSuper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.PreSubSuper();
      model.PreSubSuperProperties = GetPreSubSuperProperties(openXmlElement);
      model.SubArgument = GetSubArgument(openXmlElement);
      model.SuperArgument = GetSuperArgument(openXmlElement);
      model.Base = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.PreSubSuper? openXmlElement, DMM.PreSubSuper? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpPreSubSuperProperties(openXmlElement, model.PreSubSuperProperties, diffs, objName, propName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, model.SubArgument, diffs, objName, propName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, model.SuperArgument, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Base, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.PreSubSuper CreateOpenXmlElement(DMM.PreSubSuper model)
  {
    var openXmlElement = new DXM.PreSubSuper();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.PreSubSuper openXmlElement, DMM.PreSubSuper model)
  {
    SetPreSubSuperProperties(openXmlElement, model?.PreSubSuperProperties);
    SetSubArgument(openXmlElement, model?.SubArgument);
    SetSuperArgument(openXmlElement, model?.SuperArgument);
    SetArgument(openXmlElement, model?.Base);
    return true;
  }
  #endregion
}
