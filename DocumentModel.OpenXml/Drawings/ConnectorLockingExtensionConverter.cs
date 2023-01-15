using DocumentFormat.OpenXml.Drawing;
using Graphic = DocumentModel.Drawings.Graphic;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ConnectorLockingExtension Class.
/// </summary>
public static class ConnectorLockingExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(ConnectorLockingExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(ConnectorLockingExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static Graphic? GetGraphic(ConnectorLockingExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
    if (itemElement != null)
      return GraphicConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGraphic(ConnectorLockingExtension? openXmlElement, Graphic? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Graphic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Graphic>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ConnectorLockingExtension? CreateModelElement(ConnectorLockingExtension? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectorLockingExtension? value)
    where OpenXmlElementType : ConnectorLockingExtension, new()
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