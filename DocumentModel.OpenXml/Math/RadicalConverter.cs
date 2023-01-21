namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Radical Function.
/// </summary>
public static class RadicalConverter
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  private static DMMath.RadicalProperties? GetRadicalProperties(DXMath.Radical openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.RadicalProperties>();
    if (itemElement != null)
      return DMXMath.RadicalPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadicalProperties(DXMath.Radical openXmlElement, DMMath.RadicalProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.RadicalProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.RadicalPropertiesConverter.CreateOpenXmlElement<DXMath.RadicalProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Degree.
  /// </summary>
  private static DMMath.Degree? GetDegree(DXMath.Radical openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Degree>();
    if (itemElement != null)
      return DMXMath.DegreeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDegree(DXMath.Radical openXmlElement, DMMath.Degree? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Degree>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DegreeConverter.CreateOpenXmlElement<DXMath.Degree>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  private static DMMath.Base? GetBase(DXMath.Radical openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.Base>();
    if (itemElement != null)
      return DMXMath.BaseConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBase(DXMath.Radical openXmlElement, DMMath.Base? value)
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
  
  public static DMMath.Radical? CreateModelElement(DXMath.Radical? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Radical();
      value.RadicalProperties = GetRadicalProperties(openXmlElement);
      value.Degree = GetDegree(openXmlElement);
      value.Base = GetBase(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Radical? value)
    where OpenXmlElementType: DXMath.Radical, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRadicalProperties(openXmlElement, value?.RadicalProperties);
      SetDegree(openXmlElement, value?.Degree);
      SetBase(openXmlElement, value?.Base);
      return openXmlElement;
    }
    return default;
  }
}
