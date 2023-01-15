using DocumentModel.Drawings.Charts;
using DateAxExtensionList = DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the DateAxExtensionList Class.
/// </summary>
public static class DateAxExtensionListConverter
{
  public static Collection<DateAxExtension>? GetDateAxExtensions(DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DateAxExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>())
      {
        var newItem = DateAxExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDateAxExtensions(DateAxExtensionList? openXmlElement, Collection<DateAxExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DateAxExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.DateAxExtensionList? CreateModelElement(DateAxExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxExtensionList();
      value.DateAxExtensions = GetDateAxExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DateAxExtensionList? value)
    where OpenXmlElementType : DateAxExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDateAxExtensions(openXmlElement, value?.DateAxExtensions);
      return openXmlElement;
    }
    return default;
  }
}