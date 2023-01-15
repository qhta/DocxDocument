using DocumentModel.Drawings.Diagrams;
using StyleData = DocumentFormat.OpenXml.Drawing.Diagrams.StyleData;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the StyleData Class.
/// </summary>
public static class StyleDataConverter
{
  public static DataModel? GetDataModel(StyleData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DataModelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataModel(StyleData? openXmlElement, DataModel? value)
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

  public static DocumentModel.Drawings.Diagrams.StyleData? CreateModelElement(StyleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleData? value)
    where OpenXmlElementType : StyleData, new()
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