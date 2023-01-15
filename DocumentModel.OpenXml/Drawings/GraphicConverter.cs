using DocumentModel.Drawings;
using Graphic = DocumentFormat.OpenXml.Drawing.Graphic;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Graphic Object.
/// </summary>
public static class GraphicConverter
{
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  public static GraphicData? GetGraphicData(Graphic? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicData>();
    if (itemElement != null)
      return GraphicDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGraphicData(Graphic? openXmlElement, GraphicData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GraphicData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GraphicData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Graphic? CreateModelElement(Graphic? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Graphic();
      value.GraphicData = GetGraphicData(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Graphic? value)
    where OpenXmlElementType : Graphic, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGraphicData(openXmlElement, value?.GraphicData);
      return openXmlElement;
    }
    return default;
  }
}