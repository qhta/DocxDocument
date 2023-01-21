namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public static class BorderBoxConverter
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  private static DMMath.BorderBoxProperties? GetBorderBoxProperties(DXMath.BorderBox openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.BorderBoxProperties>();
    if (itemElement != null)
      return DMXMath.BorderBoxPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBorderBoxProperties(DXMath.BorderBox openXmlElement, DMMath.BorderBoxProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.BorderBoxProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.BorderBoxPropertiesConverter.CreateOpenXmlElement<DXMath.BorderBoxProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.BorderBox openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DXMath.BorderBox openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.BorderBox? CreateModelElement(DXMath.BorderBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.BorderBox();
      value.BorderBoxProperties = GetBorderBoxProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.BorderBox? value)
    where OpenXmlElementType: DXMath.BorderBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBorderBoxProperties(openXmlElement, value?.BorderBoxProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
