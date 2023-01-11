namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
/// Defines the NumberDiagramInfoList Class.
/// </summary>
public static class NumberDiagramInfoListConverter
{
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>? GetNumberDiagramInfos(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Diagram1.NumberDiagramInfoConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetNumberDiagramInfos(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Diagram1.NumberDiagramInfo>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Diagram1.NumberDiagramInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? CreateModelElement(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagram1.NumberDiagramInfoList();
      value.NumberDiagramInfos = GetNumberDiagramInfos(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
