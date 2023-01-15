using DocumentModel.Drawings.ChartDrawings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public static class ExtensionListConverter
{
  public static Collection<Extension2>? GetExtension2s(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Extension2>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>())
      {
        var newItem = Extension2Converter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetExtension2s(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? openXmlElement, Collection<Extension2>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = Extension2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ExtensionList();
      value.Extension2s = GetExtension2s(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtension2s(openXmlElement, value?.Extension2s);
      return openXmlElement;
    }
    return default;
  }
}