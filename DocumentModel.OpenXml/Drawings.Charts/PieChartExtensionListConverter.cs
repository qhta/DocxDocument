using DocumentModel.Drawings.Charts;
using PieChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the PieChartExtensionList Class.
/// </summary>
public static class PieChartExtensionListConverter
{
  public static Collection<PieChartExtension>? GetPieChartExtensions(PieChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PieChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>())
      {
        var newItem = PieChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPieChartExtensions(PieChartExtensionList? openXmlElement, Collection<PieChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PieChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.PieChartExtensionList? CreateModelElement(PieChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChartExtensionList();
      value.PieChartExtensions = GetPieChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PieChartExtensionList? value)
    where OpenXmlElementType : PieChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPieChartExtensions(openXmlElement, value?.PieChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}