using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the PtExtensionList Class.
/// </summary>
public static class PtExtensionListConverter
{
  public static Collection<PtExtension>? GetPtExtensions(PtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PtExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.PtExtension>())
      {
        var newItem = PtExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPtExtensions(PtExtensionList? openXmlElement, Collection<PtExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.PtExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PtExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PtExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Diagrams.PtExtensionList? CreateModelElement(PtExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PtExtensionList();
      value.PtExtensions = GetPtExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.PtExtensionList? value)
    where OpenXmlElementType : PtExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtExtensions(openXmlElement, value?.PtExtensions);
      return openXmlElement;
    }
    return default;
  }
}