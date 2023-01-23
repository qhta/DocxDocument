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
  
  private static bool CmpUri(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Uri?.Value == value;
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
    return DMXDraws.CameraToolConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010Draw.CameraTool>());
  }
  
  private static bool CmpCameraTool(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.CameraTool? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CameraToolConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010Draw.CameraTool>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.SignatureLineConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013Draw.SignatureLine>());
  }
  
  private static bool CmpSignatureLine(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SignatureLineConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013Draw.SignatureLine>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ObjectPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013Draw.ObjectProperties>());
  }
  
  private static bool CmpObjectProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.ObjectProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ObjectPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2013Draw.ObjectProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.LiveFeedPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.LiveFeedProperties>());
  }
  
  private static bool CmpLiveFeedProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.LiveFeedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LiveFeedPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.LiveFeedProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.NonVisualPicturePropertiesExtension? openXmlElement, DMDraws.NonVisualPicturePropertiesExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpCameraTool(openXmlElement, value.CameraTool, diffs, objName))
        ok = false;
      if (!CmpSignatureLine(openXmlElement, value.SignatureLine, diffs, objName))
        ok = false;
      if (!CmpObjectProperties(openXmlElement, value.ObjectProperties, diffs, objName))
        ok = false;
      if (!CmpLiveFeedProperties(openXmlElement, value.LiveFeedProperties, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
