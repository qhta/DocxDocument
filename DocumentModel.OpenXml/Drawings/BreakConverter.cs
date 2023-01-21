namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  private static DMDraws.RunProperties? GetRunProperties(DXDraw.Break openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      return DMXDraws.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunProperties(DXDraw.Break openXmlElement, DMDraws.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RunPropertiesConverter.CreateOpenXmlElement<DXDraw.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Break? CreateModelElement(DXDraw.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Break();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Break? value)
    where OpenXmlElementType: DXDraw.Break, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunProperties(openXmlElement, value?.RunProperties);
      return openXmlElement;
    }
    return default;
  }
}
