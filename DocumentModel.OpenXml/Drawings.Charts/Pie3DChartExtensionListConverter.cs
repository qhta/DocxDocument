using DocumentModel.Drawings.Charts;
using Pie3DChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Pie3DChartExtensionList Class.
/// </summary>
public static class Pie3DChartExtensionListConverter
{
  public static Collection<Pie3DChartExtension>? GetPie3DChartExtensions(Pie3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Pie3DChartExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>())
      {
        var newItem = Pie3DChartExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPie3DChartExtensions(Pie3DChartExtensionList? openXmlElement, Collection<Pie3DChartExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = Pie3DChartExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.Pie3DChartExtensionList? CreateModelElement(Pie3DChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Pie3DChartExtensionList();
      value.Pie3DChartExtensions = GetPie3DChartExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Pie3DChartExtensionList? value)
    where OpenXmlElementType : Pie3DChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPie3DChartExtensions(openXmlElement, value?.Pie3DChartExtensions);
      return openXmlElement;
    }
    return default;
  }
}