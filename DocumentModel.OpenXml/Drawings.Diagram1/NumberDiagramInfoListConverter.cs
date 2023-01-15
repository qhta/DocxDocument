using DocumentModel.Drawings.Diagram1;
using NumberDiagramInfoList = DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfoList;

namespace DocumentModel.OpenXml.Drawings.Diagram1;

/// <summary>
///   Defines the NumberDiagramInfoList Class.
/// </summary>
public static class NumberDiagramInfoListConverter
{
  public static Collection<NumberDiagramInfo>? GetNumberDiagramInfos(NumberDiagramInfoList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumberDiagramInfo>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>())
      {
        var newItem = NumberDiagramInfoConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumberDiagramInfos(NumberDiagramInfoList? openXmlElement, Collection<NumberDiagramInfo>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumberDiagramInfoConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagram1.NumberDiagramInfoList? CreateModelElement(NumberDiagramInfoList? openXmlElement)
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
    where OpenXmlElementType : NumberDiagramInfoList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberDiagramInfos(openXmlElement, value?.NumberDiagramInfos);
      return openXmlElement;
    }
    return default;
  }
}