namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public static class GroupCharConverter
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  private static DMMath.GroupCharProperties? GetGroupCharProperties(DXMath.GroupChar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.GroupCharProperties>();
    if (itemElement != null)
      return DMXMath.GroupCharPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupCharProperties(DXMath.GroupChar openXmlElement, DMMath.GroupCharProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.GroupCharProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.GroupCharPropertiesConverter.CreateOpenXmlElement<DXMath.GroupCharProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.GroupChar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DXMath.GroupChar openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.GroupChar? CreateModelElement(DXMath.GroupChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.GroupChar();
      value.GroupCharProperties = GetGroupCharProperties(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.GroupChar? value)
    where OpenXmlElementType: DXMath.GroupChar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGroupCharProperties(openXmlElement, value?.GroupCharProperties);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
