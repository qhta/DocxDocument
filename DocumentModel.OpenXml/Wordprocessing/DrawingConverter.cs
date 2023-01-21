namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// DrawingML Object.
/// </summary>
public static class DrawingConverter
{
  /// <summary>
  /// Drawing Element Anchor.
  /// </summary>
  private static DMDrawsW.Anchor? GetAnchor(DXW.Drawing openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.Anchor>();
    if (itemElement != null)
      return DMXDrawsW.AnchorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAnchor(DXW.Drawing openXmlElement, DMDrawsW.Anchor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.Anchor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.AnchorConverter.CreateOpenXmlElement<DXDrawW.Anchor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Inline Drawing Object.
  /// </summary>
  private static DMDrawsW.Inline? GetInline(DXW.Drawing openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.Inline>();
    if (itemElement != null)
      return DMXDrawsW.InlineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInline(DXW.Drawing openXmlElement, DMDrawsW.Inline? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.Inline>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsW.InlineConverter.CreateOpenXmlElement<DXDrawW.Inline>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Drawing? CreateModelElement(DXW.Drawing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Drawing();
      value.Anchor = GetAnchor(openXmlElement);
      value.Inline = GetInline(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Drawing? value)
    where OpenXmlElementType: DXW.Drawing, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAnchor(openXmlElement, value?.Anchor);
      SetInline(openXmlElement, value?.Inline);
      return openXmlElement;
    }
    return default;
  }
}
