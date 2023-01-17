namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ConnectorLockingExtensionList Class.
/// </summary>
public static class ConnectorLockingExtensionListConverter
{
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ConnectorLockingExtension> GetConnectorLockingExtensions(DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ConnectorLockingExtension>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ConnectorLockingExtensionConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetConnectorLockingExtensions(DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ConnectorLockingExtension>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ConnectorLockingExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectorLockingExtension>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ConnectorLockingExtensionList? CreateModelElement(DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ConnectorLockingExtensionList, new()
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
