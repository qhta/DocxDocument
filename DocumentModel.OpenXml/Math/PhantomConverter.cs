namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Phantom"/> class from/to OpenXml converter.
/// </summary>
public static class PhantomConverter
{
  #region Phantom Properties. conversion.
  private static DMM.PhantomProperties? GetPhantomProperties(DXM.Phantom openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.PhantomProperties>();
    if (element != null)
      return DMXM.PhantomPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPhantomProperties(DXM.Phantom openXmlElement, DMM.PhantomProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.PhantomPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.PhantomProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetPhantomProperties(DXM.Phantom openXmlElement, DMM.PhantomProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.PhantomProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.PhantomPropertiesConverter.CreateOpenXmlElement<DXM.PhantomProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.Phantom openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Phantom openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.Phantom openXmlElement, DMM.Argument? value)
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

  #region Phantom model conversion.
  public static DMM.Phantom? CreateModelElement(DXM.Phantom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Phantom();
      model.PhantomProperties = GetPhantomProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Phantom? openXmlElement, DMM.Phantom? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpPhantomProperties(openXmlElement, model.PhantomProperties, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Phantom CreateOpenXmlElement(DMM.Phantom model)
  {
    var openXmlElement = new DXM.Phantom();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Phantom openXmlElement, DMM.Phantom model)
  {
    SetPhantomProperties(openXmlElement, model.PhantomProperties);
    SetArgument(openXmlElement, model.Argument);
    return true;
  }
  #endregion
}
