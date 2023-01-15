using DocumentModel.Drawings.Charts;
using PieSerExtensionList = DocumentFormat.OpenXml.Drawing.Charts.PieSerExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the PieSerExtensionList Class.
/// </summary>
public static class PieSerExtensionListConverter
{
  public static Collection<PieSerExtension>? GetPieSerExtensions(PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PieSerExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>())
      {
        var newItem = PieSerExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPieSerExtensions(PieSerExtensionList? openXmlElement, Collection<PieSerExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PieSerExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieSerExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.PieSerExtensionList? CreateModelElement(PieSerExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieSerExtensionList();
      value.PieSerExtensions = GetPieSerExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PieSerExtensionList? value)
    where OpenXmlElementType : PieSerExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPieSerExtensions(openXmlElement, value?.PieSerExtensions);
      return openXmlElement;
    }
    return default;
  }
}