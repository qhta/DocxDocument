namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the StyleData Class.
/// </summary>
public static class StyleDataConverter
{
  private static DocumentModel.Drawings.Diagrams.DataModel? GetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.StyleData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DataModelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.StyleData openXmlElement, DocumentModel.Drawings.Diagrams.DataModel? value)
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
  
  public static DocumentModel.Drawings.Diagrams.StyleData? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.StyleData? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.StyleData, new()
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
