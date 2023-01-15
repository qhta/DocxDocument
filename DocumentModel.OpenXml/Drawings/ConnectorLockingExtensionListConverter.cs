using DocumentModel.Drawings;
using ConnectorLockingExtensionList = DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ConnectorLockingExtensionList Class.
/// </summary>
public static class ConnectorLockingExtensionListConverter
{
  public static Collection<ConnectorLockingExtension>? GetConnectorLockingExtensions(ConnectorLockingExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ConnectorLockingExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>())
      {
        var newItem = ConnectorLockingExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetConnectorLockingExtensions(ConnectorLockingExtensionList? openXmlElement, Collection<ConnectorLockingExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ConnectorLockingExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ConnectorLockingExtensionList? CreateModelElement(ConnectorLockingExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectorLockingExtensionList();
      value.ConnectorLockingExtensions = GetConnectorLockingExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectorLockingExtensionList? value)
    where OpenXmlElementType : ConnectorLockingExtensionList, new()
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