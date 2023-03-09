namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public static class SubSuperscriptConverter
{
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  private static DMMath.SubSuperscriptProperties? GetSubSuperscriptProperties(DXMath.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubSuperscriptProperties>();
    if (element != null)
      return DMXMath.SubSuperscriptPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubSuperscriptProperties(DXMath.SubSuperscript openXmlElement, DMMath.SubSuperscriptProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubSuperscriptPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubSuperscriptProperties>(), value, diffs, objName);
  }
  
  private static void SetSubSuperscriptProperties(DXMath.SubSuperscript openXmlElement, DMMath.SubSuperscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubSuperscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubSuperscriptPropertiesConverter.CreateOpenXmlElement<DXMath.SubSuperscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (element != null)
      return DMXMath.BaseConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBase(DXMath.SubSuperscript openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.Base>(), value, diffs, objName);
  }
  
  private static void SetBase(DXMath.SubSuperscript openXmlElement, DMMath.Base? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Subscript (Sub-Superscript).
  /// </summary>
  private static DMMath.SubArgument? GetSubArgument(DXMath.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SubArgument>();
    if (element != null)
      return DMXMath.SubArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSubArgument(DXMath.SubSuperscript openXmlElement, DMMath.SubArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SubArgument>(), value, diffs, objName);
  }
  
  private static void SetSubArgument(DXMath.SubSuperscript openXmlElement, DMMath.SubArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SubArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SubArgumentConverter.CreateOpenXmlElement<DXMath.SubArgument>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  private static DMMath.SuperArgument? GetSuperArgument(DXMath.SubSuperscript openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (element != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSuperArgument(DXMath.SubSuperscript openXmlElement, DMMath.SuperArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperArgumentConverter.CompareModelElement(openXmlElement.GetFirstChild<DXMath.SuperArgument>(), value, diffs, objName);
  }
  
  private static void SetSuperArgument(DXMath.SubSuperscript openXmlElement, DMMath.SuperArgument? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SuperArgument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperArgumentConverter.CreateOpenXmlElement<DXMath.SuperArgument>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.SubSuperscript? CreateModelElement(DXMath.SubSuperscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.SubSuperscript();
      value.SubSuperscriptProperties = GetSubSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.SubSuperscript? openXmlElement, DMMath.SubSuperscript? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSubSuperscriptProperties(openXmlElement, value.SubSuperscriptProperties, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, value.SubArgument, diffs, objName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, value.SuperArgument, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXMath.SubSuperscript CreateOpenXmlElement(DMMath.SubSuperscript value)
  {
    var openXmlElement = new DXMath.SubSuperscript();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXMath.SubSuperscript openXmlElement, DMMath.SubSuperscript value)
  {
    SetSubSuperscriptProperties(openXmlElement, value?.SubSuperscriptProperties);
    SetBase(openXmlElement, value?.Base);
    SetSubArgument(openXmlElement, value?.SubArgument);
    SetSuperArgument(openXmlElement, value?.SuperArgument);
  }
}
