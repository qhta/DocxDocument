namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.GroupChar"/> class from/to OpenXml converter.
/// </summary>
public static class GroupCharConverter
{
  #region Group-Character Properties. conversion.
  private static DMM.GroupCharProperties? GetGroupCharProperties(DXM.GroupChar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.GroupCharProperties>();
    if (element != null)
      return DMXM.GroupCharPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupCharProperties(DXM.GroupChar openXmlElement, DMM.GroupCharProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.GroupCharPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.GroupCharProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetGroupCharProperties(DXM.GroupChar openXmlElement, DMM.GroupCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.GroupCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.GroupCharPropertiesConverter.CreateOpenXmlElement<DXM.GroupCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region Base conversion.
  private static DMM.Argument? GetArgument(DXM.GroupChar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.GroupChar openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.GroupChar openXmlElement, DMM.Argument? value)
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

  #region GroupChar model conversion.
  public static DMM.GroupChar? CreateModelElement(DXM.GroupChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.GroupChar();
      model.GroupCharProperties = GetGroupCharProperties(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.GroupChar? openXmlElement, DMM.GroupChar? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpGroupCharProperties(openXmlElement, model.GroupCharProperties, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.GroupChar CreateOpenXmlElement(DMM.GroupChar model)
  {
    var openXmlElement = new DXM.GroupChar();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.GroupChar openXmlElement, DMM.GroupChar model)
  {
    SetGroupCharProperties(openXmlElement, model.GroupCharProperties);
    SetArgument(openXmlElement, model.Argument);
    return true;
  }
  #endregion
}
