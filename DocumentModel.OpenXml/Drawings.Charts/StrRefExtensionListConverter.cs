using DocumentModel.Drawings.Charts;
using StrRefExtensionList = DocumentFormat.OpenXml.Drawing.Charts.StrRefExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the StrRefExtensionList Class.
/// </summary>
public static class StrRefExtensionListConverter
{
  public static Collection<StrRefExtension>? GetStrRefExtensions(StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<StrRefExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>())
      {
        var newItem = StrRefExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetStrRefExtensions(StrRefExtensionList? openXmlElement, Collection<StrRefExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StrRefExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrRefExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.StrRefExtensionList? CreateModelElement(StrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StrRefExtensionList();
      value.StrRefExtensions = GetStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StrRefExtensionList? value)
    where OpenXmlElementType : StrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStrRefExtensions(openXmlElement, value?.StrRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}