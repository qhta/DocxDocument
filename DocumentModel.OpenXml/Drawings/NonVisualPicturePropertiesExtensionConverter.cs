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
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDraws.CameraTool? GetCameraTool(DXDraw.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010Draw.CameraTool>();
    if (element != null)
      return DMXDraws.CameraToolConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCameraTool(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.CameraTool? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CameraToolConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010Draw.CameraTool>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2013Draw.SignatureLine>();
    if (element != null)
      return DMXDraws.SignatureLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSignatureLine(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Draw.SignatureLine>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2013Draw.ObjectProperties>();
    if (element != null)
      return DMXDraws.ObjectPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpObjectProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.ObjectProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ObjectPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Draw.ObjectProperties>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.LiveFeedProperties>();
    if (element != null)
      return DMXDraws.LiveFeedPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLiveFeedProperties(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.LiveFeedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LiveFeedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.LiveFeedProperties>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtension? CreateModelElement(DXDraw.NonVisualPicturePropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualPicturePropertiesExtension();
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.NonVisualPicturePropertiesExtension value)
    where OpenXmlElementType: DXDraw.NonVisualPicturePropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.NonVisualPicturePropertiesExtension openXmlElement, DMDraws.NonVisualPicturePropertiesExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetCameraTool(openXmlElement, value?.CameraTool);
    SetSignatureLine(openXmlElement, value?.SignatureLine);
    SetObjectProperties(openXmlElement, value?.ObjectProperties);
    SetLiveFeedProperties(openXmlElement, value?.LiveFeedProperties);
  }
}
