namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Top and Bottom Wrapping.
/// </summary>
public static class WrapTopBottomConverter
{
  /// <summary>
  /// Distance From Text on Top Edge
  /// </summary>
  private static UInt32? GetDistanceFromTop(DXDrawW.WrapTopBottom openXmlElement)
  {
    return openXmlElement.DistanceFromTop?.Value;
  }
  
  private static void SetDistanceFromTop(DXDrawW.WrapTopBottom openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromTop = value;
  }
  
  /// <summary>
  /// Distance From Text on Bottom Edge
  /// </summary>
  private static UInt32? GetDistanceFromBottom(DXDrawW.WrapTopBottom openXmlElement)
  {
    return openXmlElement.DistanceFromBottom?.Value;
  }
  
  private static void SetDistanceFromBottom(DXDrawW.WrapTopBottom openXmlElement, UInt32? value)
  {
    openXmlElement.DistanceFromBottom = value;
  }
  
  /// <summary>
  /// Wrapping Boundaries.
  /// </summary>
  private static DMDrawsW.EffectExtent? GetEffectExtent(DXDrawW.WrapTopBottom openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.EffectExtent>();
    if (itemElement != null)
      return DMXDrawsW.EffectExtentConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEffectExtent(DXDrawW.WrapTopBottom openXmlElement, DMDrawsW.EffectExtent? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.EffectExtent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.EffectExtentConverter.CreateOpenXmlElement<DXDrawW.EffectExtent>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsW.WrapTopBottom? CreateModelElement(DXDrawW.WrapTopBottom? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.WrapTopBottom();
      value.DistanceFromTop = GetDistanceFromTop(openXmlElement);
      value.DistanceFromBottom = GetDistanceFromBottom(openXmlElement);
      value.EffectExtent = GetEffectExtent(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.WrapTopBottom? value)
    where OpenXmlElementType: DXDrawW.WrapTopBottom, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDistanceFromTop(openXmlElement, value?.DistanceFromTop);
      SetDistanceFromBottom(openXmlElement, value?.DistanceFromBottom);
      SetEffectExtent(openXmlElement, value?.EffectExtent);
      return openXmlElement;
    }
    return default;
  }
}
