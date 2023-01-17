namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorData Class.
/// </summary>
public static class ColorDataConverter
{
  private static DocumentModel.Drawings.Diagrams.DataModel? GetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.ColorData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DataModelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.ColorData openXmlElement, DocumentModel.Drawings.Diagrams.DataModel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Diagrams.DataModelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorData? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ColorData? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ColorData, new()
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
