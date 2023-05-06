namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtension Class.
/// </summary>
public static class ConnectorLockingExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.ConnectorLockingExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.ConnectorLockingExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.ConnectorLockingExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMD.Graphic? GetGraphic(DXD.ConnectorLockingExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Graphic>();
    if (element != null)
      return DMXD.GraphicConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGraphic(DXD.ConnectorLockingExtension openXmlElement, DMD.Graphic? value, DiffList? diffs, string? objName)
  {
    return DMXD.GraphicConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Graphic>(), value, diffs, objName);
  }
  
  private static void SetGraphic(DXD.ConnectorLockingExtension openXmlElement, DMD.Graphic? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Graphic>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.GraphicConverter.CreateOpenXmlElement<DXD.Graphic>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ConnectorLockingExtension? CreateModelElement(DXD.ConnectorLockingExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectorLockingExtension();
      value.Uri = GetUri(openXmlElement);
      value.Graphic = GetGraphic(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ConnectorLockingExtension? openXmlElement, DMD.ConnectorLockingExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpGraphic(openXmlElement, value.Graphic, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ConnectorLockingExtension value)
    where OpenXmlElementType: DXD.ConnectorLockingExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ConnectorLockingExtension openXmlElement, DMD.ConnectorLockingExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetGraphic(openXmlElement, value?.Graphic);
  }
}
