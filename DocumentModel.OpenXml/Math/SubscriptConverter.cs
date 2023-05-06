namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Subscript"/> class from/to OpenXml converter.
/// </summary>
public static class SubscriptConverter
{
  #region Subscript Properties. conversion.
  private static DMM.SubscriptProperties? GetSubscriptProperties(DXM.Subscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubscriptProperties>();
    if (element != null)
      return DMXM.SubscriptPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubscriptProperties(DXM.Subscript openXmlElement, DMM.SubscriptProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.SubscriptPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubscriptProperties>(), value, diffs, objName);
  }
  
  private static void SetSubscriptProperties(DXM.Subscript openXmlElement, DMM.SubscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.SubscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.SubscriptPropertiesConverter.CreateOpenXmlElement<DXM.SubscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.Subscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Subscript openXmlElement, DMM.Argument? value, DiffList? diffs, string? objName)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName);
  }
  
  private static void SetArgument(DXM.Subscript openXmlElement, DMM.Argument? value)
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

  #region Subscript (Subscript function) conversion.
  private static DMM.SubArgument? GetSubArgument(DXM.Subscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubArgument>();
    if (element != null)
      return DMXM.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXM.Subscript openXmlElement, DMM.SubArgument? value, DiffList? diffs, string? objName)
  {
    return DMXM.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubArgument>(), value, diffs, objName);
  }
  
  private static void SetSubArgument(DXM.Subscript openXmlElement, DMM.SubArgument? value)
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

  #region Subscript model conversion.
  public static DMM.Subscript? CreateModelElement(DXM.Subscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Subscript();
      model.SubscriptProperties = GetSubscriptProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      model.SubArgument = GetSubArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Subscript? openXmlElement, DMM.Subscript? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpSubscriptProperties(openXmlElement, model.SubscriptProperties, diffs, objName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, model.SubArgument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Subscript CreateOpenXmlElement(DMM.Subscript model)
  {
    var openXmlElement = new DXM.Subscript();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Subscript openXmlElement, DMM.Subscript model)
  {
    SetSubscriptProperties(openXmlElement, model?.SubscriptProperties);
    SetArgument(openXmlElement, model?.Argument);
    SetSubArgument(openXmlElement, model?.SubArgument);
    return true;
  }
  #endregion
}
