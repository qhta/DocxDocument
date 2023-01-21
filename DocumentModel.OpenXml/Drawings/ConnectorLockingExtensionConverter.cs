namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public static class ConnectorLockingExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.ConnectorLockingExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.ConnectorLockingExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.Graphic? GetGraphic(DXDraw.ConnectorLockingExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Graphic>();
    if (itemElement != null)
      return DMXDraws.GraphicConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGraphic(DXDraw.ConnectorLockingExtension openXmlElement, DMDraws.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.GraphicConverter.CreateOpenXmlElement<DXDraw.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ConnectorLockingExtension? CreateModelElement(DXDraw.ConnectorLockingExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ConnectorLockingExtension();
      value.Uri = GetUri(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectorLockingExtension? value)
    where OpenXmlElementType: DXDraw.ConnectorLockingExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetGraphic(openXmlElement, value?.Graphic);
      return openXmlElement;
    }
    return default;
  }
}
