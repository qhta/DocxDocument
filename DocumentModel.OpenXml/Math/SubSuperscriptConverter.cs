namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.SubSuperscript"/> class from/to OpenXml converter.
/// </summary>
public static class SubSuperscriptConverter
{
  #region Sub-Superscript Properties. conversion.
  private static DMM.SubSuperscriptProperties? GetSubSuperscriptProperties(DXM.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubSuperscriptProperties>();
    if (element != null)
      return DMXM.SubSuperscriptPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscriptProperties(DXM.SubSuperscript openXmlElement, DMM.SubSuperscriptProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SubSuperscriptPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubSuperscriptProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetSubSuperscriptProperties(DXM.SubSuperscript openXmlElement, DMM.SubSuperscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SubSuperscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SubSuperscriptPropertiesConverter.CreateOpenXmlElement<DXM.SubSuperscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.SubSuperscript openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.SubSuperscript openXmlElement, DMM.Argument? value)
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

  #region Subscript (Sub-Superscript) conversion.
  private static DMM.SubArgument? GetSubArgument(DXM.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubArgument>();
    if (element != null)
      return DMXM.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXM.SubSuperscript openXmlElement, DMM.SubArgument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubArgument>(), value, diffs, objName, propName);
  }
  
  private static void SetSubArgument(DXM.SubSuperscript openXmlElement, DMM.SubArgument? value)
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

  #region Superscript (Sub-Superscript function) conversion.
  private static DMM.SuperArgument? GetSuperArgument(DXM.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SuperArgument>();
    if (element != null)
      return DMXM.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXM.SubSuperscript openXmlElement, DMM.SuperArgument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SuperArgument>(), value, diffs, objName, propName);
  }
  
  private static void SetSuperArgument(DXM.SubSuperscript openXmlElement, DMM.SuperArgument? value)
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

  #region SubSuperscript model conversion.
  public static DMM.SubSuperscript? CreateModelElement(DXM.SubSuperscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.SubSuperscript();
      model.SubSuperscriptProperties = GetSubSuperscriptProperties(openXmlElement);
      model.Base = GetArgument(openXmlElement);
      model.SubArgument = GetSubArgument(openXmlElement);
      model.SuperArgument = GetSuperArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.SubSuperscript? openXmlElement, DMM.SubSuperscript? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpSubSuperscriptProperties(openXmlElement, model.SubSuperscriptProperties, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Base, diffs, objName, propName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, model.SubArgument, diffs, objName, propName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, model.SuperArgument, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.SubSuperscript CreateOpenXmlElement(DMM.SubSuperscript model)
  {
    var openXmlElement = new DXM.SubSuperscript();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.SubSuperscript openXmlElement, DMM.SubSuperscript model)
  {
    SetSubSuperscriptProperties(openXmlElement, model?.SubSuperscriptProperties);
    SetArgument(openXmlElement, model?.Base);
    SetSubArgument(openXmlElement, model?.SubArgument);
    SetSuperArgument(openXmlElement, model?.SuperArgument);
    return true;
  }
  #endregion
}
