namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public static class SuperscriptConverter
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  private static DMMath.SuperscriptProperties? GetSuperscriptProperties(DXMath.Superscript openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SuperscriptProperties>();
    if (itemElement != null)
      return DMXMath.SuperscriptPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSuperscriptProperties(DXMath.Superscript openXmlElement, DMMath.SuperscriptProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.SuperscriptProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.SuperscriptPropertiesConverter.CreateOpenXmlElement<DXMath.SuperscriptProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Superscript openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DXMath.Superscript openXmlElement, DMMath.Base? value)
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
  /// Superscript (Superscript function).
  /// </summary>
  private static DMMath.SuperArgument? GetSuperArgument(DXMath.Superscript openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.SuperArgument>();
    if (itemElement != null)
      return DMXMath.SuperArgumentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSuperArgument(DXMath.Superscript openXmlElement, DMMath.SuperArgument? value)
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
  
  public static DMMath.Superscript? CreateModelElement(DXMath.Superscript? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Superscript();
      value.SuperscriptProperties = GetSuperscriptProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      value.SuperArgument = GetSuperArgument(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Superscript? value)
    where OpenXmlElementType: DXMath.Superscript, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSuperscriptProperties(openXmlElement, value?.SuperscriptProperties);
      SetBase(openXmlElement, value?.Base);
      SetSuperArgument(openXmlElement, value?.SuperArgument);
      return openXmlElement;
    }
    return default;
  }
}
