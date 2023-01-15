using DocumentModel.Drawings.Charts;
using Line3DChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Line3DChartExtensionList Class.
/// </summary>
public static class Line3DChartExtensionListConverter
{
  public static Collection<Line3DChartExtension>? GetLine3DChartExtensions(Line3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Line3DChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>())
      {
        var newItem = Line3DChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLine3DChartExtensions(Line3DChartExtensionList? openXmlElement, Collection<Line3DChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = Line3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.Line3DChartExtensionList? CreateModelElement(Line3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChartExtensionList();
      value.Line3DChartExtensions = GetLine3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Line3DChartExtensionList? value)
    where OpenXmlElementType : Line3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLine3DChartExtensions(openXmlElement, value?.Line3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}