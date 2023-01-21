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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.PreSubSuperProperties>();
    if (itemElement != null)
      return DMXMath.PreSubSuperPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SubArgument>();
    if (itemElement != null)
      return DMXMath.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (itemElement != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
