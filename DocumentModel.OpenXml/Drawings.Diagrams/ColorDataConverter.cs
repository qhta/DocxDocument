using DocumentModel.Drawings.Diagrams;
using ColorData = DocumentFormat.OpenXml.Drawing.Diagrams.ColorData;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the ColorData Class.
/// </summary>
public static class ColorDataConverter
{
  public static DataModel? GetDataModel(ColorData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DataModelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataModel(ColorData? openXmlElement, DataModel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ColorData? CreateModelElement(ColorData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorData? value)
    where OpenXmlElementType : ColorData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataModel(openXmlElement, value?.DataModel);
      return openXmlElement;
    }
    return default;
  }
}