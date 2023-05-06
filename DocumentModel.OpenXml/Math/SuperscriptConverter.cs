namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Superscript"/> class from/to OpenXml converter.
/// </summary>
public static class SuperscriptConverter
{
  #region Superscript Properties. conversion.
  private static DMM.SuperscriptProperties? GetSuperscriptProperties(DXM.Superscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SuperscriptProperties>();
    if (element != null)
      return DMXM.SuperscriptPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperscriptProperties(DXM.Superscript openXmlElement, DMM.SuperscriptProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.SuperscriptPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SuperscriptProperties>(), value, diffs, objName);
  }
  
  private static void SetSuperscriptProperties(DXM.Superscript openXmlElement, DMM.SuperscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SuperscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SuperscriptPropertiesConverter.CreateOpenXmlElement<DXM.SuperscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.Superscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Superscript openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.Superscript openXmlElement, DMM.Argument? value)
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

  #region Superscript (Superscript function) conversion.
  private static DMM.SuperArgument? GetSuperArgument(DXM.Superscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SuperArgument>();
    if (element != null)
      return DMXM.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXM.Superscript openXmlElement, DMM.SuperArgument? value, DiffList? diffs, string? objName)
  {
    return DMXM.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SuperArgument>(), value, diffs, objName);
  }
  
  private static void SetSuperArgument(DXM.Superscript openXmlElement, DMM.SuperArgument? value)
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

  #region Superscript model conversion.
  public static DMM.Superscript? CreateModelElement(DXM.Superscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Superscript();
      model.SuperscriptProperties = GetSuperscriptProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      model.SuperArgument = GetSuperArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Superscript? openXmlElement, DMM.Superscript? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpSuperscriptProperties(openXmlElement, model.SuperscriptProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, model.SuperArgument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Superscript CreateOpenXmlElement(DMM.Superscript model)
  {
    var openXmlElement = new DXM.Superscript();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Superscript openXmlElement, DMM.Superscript model)
  {
    SetSuperscriptProperties(openXmlElement, model?.SuperscriptProperties);
    SetArgument(openXmlElement, model?.Argument);
    SetSuperArgument(openXmlElement, model?.SuperArgument);
    return true;
  }
  #endregion
}
