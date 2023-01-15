using DocumentModel.Drawings.Charts;
using ChartExtensionList = DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Extensibility container.
/// </summary>
public static class ChartExtensionListConverter
{
  public static Collection<DataDisplayOptions16>? GetDataDisplayOptions16s(ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataDisplayOptions16>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>())
      {
        var newItem = DataDisplayOptions16Converter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDataDisplayOptions16s(ChartExtensionList? openXmlElement, Collection<DataDisplayOptions16>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DataDisplayOptions16Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ChartExtensionList? CreateModelElement(ChartExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartExtensionList();
      value.DataDisplayOptions16s = GetDataDisplayOptions16s(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartExtensionList? value)
    where OpenXmlElementType : ChartExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataDisplayOptions16s(openXmlElement, value?.DataDisplayOptions16s);
      return openXmlElement;
    }
    return default;
  }
}