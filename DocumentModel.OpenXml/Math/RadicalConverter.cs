namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Radical"/> class from/to OpenXml converter.
/// </summary>
public static class RadicalConverter
{
  #region Radical Properties. conversion.
  private static DMM.RadicalProperties? GetRadicalProperties(DXM.Radical openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.RadicalProperties>();
    if (element != null)
      return DMXM.RadicalPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadicalProperties(DXM.Radical openXmlElement, DMM.RadicalProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.RadicalPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.RadicalProperties>(), value, diffs, objName);
  }
  
  private static void SetRadicalProperties(DXM.Radical openXmlElement, DMM.RadicalProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.RadicalProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.RadicalPropertiesConverter.CreateOpenXmlElement<DXM.RadicalProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Degree conversion.
  private static DMM.Degree? GetDegree(DXM.Radical openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Degree>();
    if (element != null)
      return DMXM.DegreeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDegree(DXM.Radical openXmlElement, DMM.Degree? value, DiffList? diffs, string? objName)
  {
    return DMXM.DegreeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Degree>(), value, diffs, objName);
  }
  
  private static void SetDegree(DXM.Radical openXmlElement, DMM.Degree? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.Degree>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.DegreeConverter.CreateOpenXmlElement<DXM.Degree>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.Radical openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Radical openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.Radical openXmlElement, DMM.Argument? value)
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

  #region Radical model conversion.
  public static DMM.Radical? CreateModelElement(DXM.Radical? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Radical();
      model.RadicalProperties = GetRadicalProperties(openXmlElement);
      model.Degree = GetDegree(openXmlElement);
      model.Base = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Radical? openXmlElement, DMM.Radical? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpRadicalProperties(openXmlElement, model.RadicalProperties, diffs, objName))
        ok = false;
      if (!CmpDegree(openXmlElement, model.Degree, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Base, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Radical CreateOpenXmlElement(DMM.Radical model)
  {
    var openXmlElement = new DXM.Radical();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Radical openXmlElement, DMM.Radical model)
  {
    SetRadicalProperties(openXmlElement, model?.RadicalProperties);
    SetDegree(openXmlElement, model?.Degree);
    SetArgument(openXmlElement, model?.Base);
    return true;
  }
  #endregion
}
