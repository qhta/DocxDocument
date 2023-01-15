using DocumentModel.Drawings.Charts;
using ValAxExtensionList = DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ValAxExtensionList Class.
/// </summary>
public static class ValAxExtensionListConverter
{
  public static Collection<ValAxExtension>? GetValAxExtensions(ValAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ValAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>())
      {
        var newItem = ValAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetValAxExtensions(ValAxExtensionList? openXmlElement, Collection<ValAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = ValAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ValAxExtensionList? CreateModelElement(ValAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValAxExtensionList();
      value.ValAxExtensions = GetValAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ValAxExtensionList? value)
    where OpenXmlElementType : ValAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetValAxExtensions(openXmlElement, value?.ValAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}