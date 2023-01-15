using DocumentModel.Drawings.Charts;
using MultiLvlStrRefExtensionList = DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtensionList;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the MultiLvlStrRefExtensionList Class.
/// </summary>
public static class MultiLvlStrRefExtensionListConverter
{
  public static Collection<MultiLvlStrRefExtension>? GetMultiLvlStrRefExtensions(MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<MultiLvlStrRefExtension>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>())
      {
        var newItem = MultiLvlStrRefExtensionConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetMultiLvlStrRefExtensions(MultiLvlStrRefExtensionList? openXmlElement, Collection<MultiLvlStrRefExtension>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = MultiLvlStrRefExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLvlStrRefExtension>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? CreateModelElement(MultiLvlStrRefExtensionList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList();
      value.MultiLvlStrRefExtensions = GetMultiLvlStrRefExtensions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MultiLvlStrRefExtensionList? value)
    where OpenXmlElementType : MultiLvlStrRefExtensionList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLvlStrRefExtensions(openXmlElement, value?.MultiLvlStrRefExtensions);
      return openXmlElement;
    }
    return default;
  }
}