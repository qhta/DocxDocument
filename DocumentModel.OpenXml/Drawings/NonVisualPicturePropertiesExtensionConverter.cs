namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.NonVisualPicturePropertiesExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDraws.CameraTool? GetCameraTool(DXDraw.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010Draw.CameraTool>();
    if (itemElement != null)
      return DMXDraws.CameraToolConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCameraTool(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.CameraTool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.CameraTool>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CameraToolConverter.CreateOpenXmlElement<DXO2010Draw.CameraTool>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.SignatureLine? GetSignatureLine(DXDraw.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013Draw.SignatureLine>();
    if (itemElement != null)
      return DMXDraws.SignatureLineConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSignatureLine(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.SignatureLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Draw.SignatureLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.SignatureLineConverter.CreateOpenXmlElement<DXO2013Draw.SignatureLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ObjectProperties? GetObjectProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013Draw.ObjectProperties>();
    if (itemElement != null)
      return DMXDraws.ObjectPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetObjectProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.ObjectProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Draw.ObjectProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ObjectPropertiesConverter.CreateOpenXmlElement<DXO2013Draw.ObjectProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LiveFeedProperties? GetLiveFeedProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.LiveFeedProperties>();
    if (itemElement != null)
      return DMXDraws.LiveFeedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLiveFeedProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.LiveFeedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.LiveFeedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LiveFeedPropertiesConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.LiveFeedProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.NonVisualPicturePropertiesExtension? CreateModelElement(DXDraw.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.NonVisualPicturePropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.CameraTool = GetCameraTool(openXmlElement);
      value.SignatureLine = GetSignatureLine(openXmlElement);
      value.ObjectProperties = GetObjectProperties(openXmlElement);
      value.LiveFeedProperties = GetLiveFeedProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualPicturePropertiesExtension? value)
    where OpenXmlElementType: DXDraw.NonVisualPicturePropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetCameraTool(openXmlElement, value?.CameraTool);
      SetSignatureLine(openXmlElement, value?.SignatureLine);
      SetObjectProperties(openXmlElement, value?.ObjectProperties);
      SetLiveFeedProperties(openXmlElement, value?.LiveFeedProperties);
      return openXmlElement;
    }
    return default;
  }
}
