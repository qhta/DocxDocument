namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public static class NonVisualPicturePropertiesExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.NonVisualPicturePropertiesExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.NonVisualPicturePropertiesExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.NonVisualPicturePropertiesExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.CameraTool? GetCameraTool(DXD.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10D.CameraTool>();
    if (element != null)
      return DMXD.CameraToolConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCameraTool(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.CameraTool? value, DiffList? diffs, string? objName)
  {
    return DMXD.CameraToolConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10D.CameraTool>(), value, diffs, objName);
  }
  
  private static void SetCameraTool(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.CameraTool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10D.CameraTool>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CameraToolConverter.CreateOpenXmlElement<DXO10D.CameraTool>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.SignatureLine? GetSignatureLine(DXD.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13D.SignatureLine>();
    if (element != null)
      return DMXD.SignatureLineConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSignatureLine(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.SignatureLine? value, DiffList? diffs, string? objName)
  {
    return DMXD.SignatureLineConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13D.SignatureLine>(), value, diffs, objName);
  }
  
  private static void SetSignatureLine(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.SignatureLine? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13D.SignatureLine>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.SignatureLineConverter.CreateOpenXmlElement<DXO13D.SignatureLine>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.ObjectProperties? GetObjectProperties(DXD.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13D.ObjectProperties>();
    if (element != null)
      return DMXD.ObjectPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpObjectProperties(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.ObjectProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.ObjectPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13D.ObjectProperties>(), value, diffs, objName);
  }
  
  private static void SetObjectProperties(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.ObjectProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13D.ObjectProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ObjectPropertiesConverter.CreateOpenXmlElement<DXO13D.ObjectProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.LiveFeedProperties? GetLiveFeedProperties(DXD.NonVisualPicturePropertiesExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.LiveFeedProperties>();
    if (element != null)
      return DMXD.LiveFeedPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLiveFeedProperties(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.LiveFeedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.LiveFeedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.LiveFeedProperties>(), value, diffs, objName);
  }
  
  private static void SetLiveFeedProperties(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.LiveFeedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.LiveFeedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LiveFeedPropertiesConverter.CreateOpenXmlElement<DXO21DL.LiveFeedProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.NonVisualPicturePropertiesExtension? CreateModelElement(DXD.NonVisualPicturePropertiesExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.NonVisualPicturePropertiesExtension? openXmlElement, DMD.NonVisualPicturePropertiesExtension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.NonVisualPicturePropertiesExtension value)
    where OpenXmlElementType: DXD.NonVisualPicturePropertiesExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.NonVisualPicturePropertiesExtension openXmlElement, DMD.NonVisualPicturePropertiesExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetCameraTool(openXmlElement, value?.CameraTool);
    SetSignatureLine(openXmlElement, value?.SignatureLine);
    SetObjectProperties(openXmlElement, value?.ObjectProperties);
    SetLiveFeedProperties(openXmlElement, value?.LiveFeedProperties);
  }
}
