namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
public static class PreSubSuperConverter
{
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  private static DMMath.PreSubSuperProperties? GetPreSubSuperProperties(DXMath.PreSubSuper openXmlElement)
  {
    return DMXMath.PreSubSuperPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.PreSubSuperProperties>());
  }
  
  private static bool CmpPreSubSuperProperties(DXMath.PreSubSuper openXmlElement, DMMath.PreSubSuperProperties? value, DiffList? diffs, string? objName)
  {
    return DMXMath.PreSubSuperPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.PreSubSuperProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreSubSuperProperties(DXMath.PreSubSuper openXmlElement, DMMath.PreSubSuperProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.PreSubSuperProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.PreSubSuperPropertiesConverter.CreateOpenXmlElement<DXMath.PreSubSuperProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  private static DMMath.SubArgument? GetSubArgument(DXMath.PreSubSuper openXmlElement)
  {
    return DMXMath.SubArgumentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.SubArgument>());
  }
  
  private static bool CmpSubArgument(DXMath.PreSubSuper openXmlElement, DMMath.SubArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SubArgumentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.SubArgument>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSubArgument(DXMath.PreSubSuper openXmlElement, DMMath.SubArgument? value)
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
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  private static DMMath.SuperArgument? GetSuperArgument(DXMath.PreSubSuper openXmlElement)
  {
    return DMXMath.SuperArgumentConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.SuperArgument>());
  }
  
  private static bool CmpSuperArgument(DXMath.PreSubSuper openXmlElement, DMMath.SuperArgument? value, DiffList? diffs, string? objName)
  {
    return DMXMath.SuperArgumentConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.SuperArgument>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSuperArgument(DXMath.PreSubSuper openXmlElement, DMMath.SuperArgument? value)
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
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.PreSubSuper openXmlElement)
  {
    return DMXMath.BaseConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXMath.Base>());
  }
  
  private static bool CmpBase(DXMath.PreSubSuper openXmlElement, DMMath.Base? value, DiffList? diffs, string? objName)
  {
    return DMXMath.BaseConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXMath.Base>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBase(DXMath.PreSubSuper openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.PreSubSuper? CreateModelElement(DXMath.PreSubSuper? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.PreSubSuper();
      value.PreSubSuperProperties = GetPreSubSuperProperties(openXmlElement);
      value.SubArgument = GetSubArgument(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXMath.PreSubSuper? openXmlElement, DMMath.PreSubSuper? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreSubSuperProperties(openXmlElement, value.PreSubSuperProperties, diffs, objName))
        ok = false;
      if (!CmpSubArgument(openXmlElement, value.SubArgument, diffs, objName))
        ok = false;
      if (!CmpSuperArgument(openXmlElement, value.SuperArgument, diffs, objName))
        ok = false;
      if (!CmpBase(openXmlElement, value.Base, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.PreSubSuper? value)
    where OpenXmlElementType: DXMath.PreSubSuper, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreSubSuperProperties(openXmlElement, value?.PreSubSuperProperties);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
