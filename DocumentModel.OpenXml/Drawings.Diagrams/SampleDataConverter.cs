namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the SampleData Class.
/// </summary>
public static class SampleDataConverter
{
  public static DocumentModel.Drawings.Diagrams.DataModel? GetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.SampleData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DataModel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.DataModelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataModel(DocumentFormat.OpenXml.Drawing.Diagrams.SampleData? openXmlElement, DocumentModel.Drawings.Diagrams.DataModel? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.SampleData? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.SampleData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.SampleData();
      value.DataModel = GetDataModel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.SampleData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.SampleData, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
