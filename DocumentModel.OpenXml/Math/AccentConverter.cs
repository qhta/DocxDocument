namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Accent.
/// </summary>
public static class AccentConverter
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  private static DMMath.AccentProperties? GetAccentProperties(DXMath.Accent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.AccentProperties>();
    if (itemElement != null)
      return DMXMath.AccentPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAccentProperties(DXMath.Accent openXmlElement, DMMath.AccentProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.AccentProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.AccentPropertiesConverter.CreateOpenXmlElement<DXMath.AccentProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Accent openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DXMath.Accent openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.Accent? CreateModelElement(DXMath.Accent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Accent();
      value.AccentProperties = GetAccentProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Accent? value)
    where OpenXmlElementType: DXMath.Accent, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAccentProperties(openXmlElement, value?.AccentProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
