using DocumentModel.Drawings.Charts;
using NumRefExtensionList = DocumentFormat.OpenXml.Drawing.Charts.NumRefExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the NumRefExtensionList Class.
/// </summary>
public static class NumRefExtensionListConverter
{
  public static Collection<NumRefExtension>? GetNumRefExtensions(NumRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumRefExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>())
      {
        var newItem = NumRefExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumRefExtensions(NumRefExtensionList? openXmlElement, Collection<NumRefExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumRefExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumRefExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.NumRefExtensionList? CreateModelElement(NumRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumRefExtensionList();
      value.NumRefExtensions = GetNumRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumRefExtensionList? value)
    where OpenXmlElementType : NumRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumRefExtensions(openXmlElement, value?.NumRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}