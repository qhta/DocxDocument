namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.Nary"/> class from/to OpenXml converter.
/// </summary>
public static class NaryConverter
{
  #region n-ary Properties conversion.
  private static DMM.NaryProperties? GetNaryProperties(DXM.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.NaryProperties>();
    if (element != null)
      return DMXM.NaryPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNaryProperties(DXM.Nary openXmlElement, DMM.NaryProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.NaryPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.NaryProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetNaryProperties(DXM.Nary openXmlElement, DMM.NaryProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.NaryProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.NaryPropertiesConverter.CreateOpenXmlElement<DXM.NaryProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region SubArgument conversion.
  private static DMM.SubArgument? GetSubArgument(DXM.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SubArgument>();
    if (element != null)
      return DMXM.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXM.Nary openXmlElement, DMM.SubArgument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SubArgument>(), value, diffs, objName, propName);
  }
  
  private static void SetSubArgument(DXM.Nary openXmlElement, DMM.SubArgument? value)
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

  #region SuperArgument conversion.
  private static DMM.SuperArgument? GetSuperArgument(DXM.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.SuperArgument>();
    if (element != null)
      return DMXM.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXM.Nary openXmlElement, DMM.SuperArgument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.SuperArgument>(), value, diffs, objName, propName);
  }
  
  private static void SetSuperArgument(DXM.Nary openXmlElement, DMM.SuperArgument? value)
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

  #region Base (Argument) conversion.
  private static DMM.Argument? GetArgument(DXM.Nary openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.Base>();
    if (element != null)
      return DMXM.ArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpArgument(DXM.Nary openXmlElement, DMM.Argument? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXM.ArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.Base>(), value, diffs, objName, propName);
  }
  
  private static void SetArgument(DXM.Nary openXmlElement, DMM.Argument? value)
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

  #region Nary model conversion.
  public static DMM.Nary? CreateModelElement(DXM.Nary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.Nary();
      model.NaryProperties = GetNaryProperties(openXmlElement);
      model.SubArgument = GetSubArgument(openXmlElement);
      model.SuperArgument = GetSuperArgument(openXmlElement);
      model.Argument = GetArgument(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.Nary? openXmlElement, DMM.Nary? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpNaryProperties(openXmlElement, model.NaryProperties, diffs, objName, propName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, model.SubArgument, diffs, objName, propName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, model.SuperArgument, diffs, objName, propName))
        ok = false;
      if (!CmpArgument(openXmlElement, model.Argument, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXM.Nary CreateOpenXmlElement(DMM.Nary model)
  {
    var openXmlElement = new DXM.Nary();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXM.Nary openXmlElement, DMM.Nary model)
  {
    SetNaryProperties(openXmlElement, model.NaryProperties);
    SetSubArgument(openXmlElement, model.SubArgument);
    SetSuperArgument(openXmlElement, model.SuperArgument);
    SetArgument(openXmlElement, model.Argument);
    return true;
  }
  #endregion
}
