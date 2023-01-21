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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SubSuperscriptProperties>();
    if (itemElement != null)
      return DMXMath.SubSuperscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SubArgument>();
    if (itemElement != null)
      return DMXMath.SubArgumentConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (itemElement != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.SubSuperscript? value)
    where OpenXmlElementType: DXMath.SubSuperscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSubSuperscriptProperties(openXmlElement, value?.SubSuperscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSubArgument(openXmlElement, value?.SubArgument);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      return openXmlElement;
    }
    return default;
  }
}
