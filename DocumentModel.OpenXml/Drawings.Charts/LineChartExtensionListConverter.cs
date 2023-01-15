using DocumentModel.Drawings.Charts;
using LineChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.LineChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the LineChartExtensionList Class.
/// </summary>
public static class LineChartExtensionListConverter
{
  public static Collection<LineChartExtension>? GetLineChartExtensions(LineChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LineChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>())
      {
        var newItem = LineChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLineChartExtensions(LineChartExtensionList? openXmlElement, Collection<LineChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LineChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.LineChartExtensionList? CreateModelElement(LineChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineChartExtensionList();
      value.LineChartExtensions = GetLineChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineChartExtensionList? value)
    where OpenXmlElementType : LineChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineChartExtensions(openXmlElement, value?.LineChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}