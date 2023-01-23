namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public static class ConnectorLockingExtensionListConverter
{
  private static Collection<DMDraws.ConnectorLockingExtension> GetConnectorLockingExtensions(DXDraw.ConnectorLockingExtensionList openXmlElement)
  {
    var collection = new Collection<DMDraws.ConnectorLockingExtension>();
    foreach (var item in openXmlElement.Elements<DXDraw.ConnectorLockingExtension>())
    {
      var newItem = DMXDraws.ConnectorLockingExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpConnectorLockingExtensions(DXDraw.ConnectorLockingExtensionList openXmlElement, Collection<DMDraws.ConnectorLockingExtension>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetConnectorLockingExtensions(DXDraw.ConnectorLockingExtensionList openXmlElement, Collection<DMDraws.ConnectorLockingExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DXDraw.ConnectorLockingExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDraws.ConnectorLockingExtensionConverter.CreateOpenXmlElement<DXDraw.ConnectorLockingExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMDraws.ConnectorLockingExtensionList? CreateModelElement(DXDraw.ConnectorLockingExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ConnectorLockingExtensionList();
      value.ConnectorLockingExtensions = GetConnectorLockingExtensions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ConnectorLockingExtensionList? openXmlElement, DMDraws.ConnectorLockingExtensionList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConnectorLockingExtensions(openXmlElement, value.ConnectorLockingExtensions, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ConnectorLockingExtensionList? value)
    where OpenXmlElementType: DXDraw.ConnectorLockingExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnectorLockingExtensions(openXmlElement, value?.ConnectorLockingExtensions);
      return openXmlElement;
    }
    return default;
  }
}
