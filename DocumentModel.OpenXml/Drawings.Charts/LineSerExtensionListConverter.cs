using DocumentModel.Drawings.Charts;
using LineSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.LineSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the LineSerExtensionList Class.
/// </summary>
public static class LineSerExtensionListConverter
{
  public static Collection<LineSerExtension>? GetLineSerExtensions(LineSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<LineSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>())
      {
        var newItem = LineSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLineSerExtensions(LineSerExtensionList? openXmlElement, Collection<LineSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LineSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.LineSerExtensionList? CreateModelElement(LineSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineSerExtensionList();
      value.LineSerExtensions = GetLineSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineSerExtensionList? value)
    where OpenXmlElementType : LineSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineSerExtensions(openXmlElement, value?.LineSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}