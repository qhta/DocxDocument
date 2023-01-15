using DocumentFormat.OpenXml.Drawing.Charts;
using Level = DocumentModel.Drawings.Charts.Level;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the MultiLevelStringCache Class.
/// </summary>
public static class MultiLevelStringCacheConverter
{
  /// <summary>
  ///   PointCount.
  /// </summary>
  public static UInt32? GetPointCount(MultiLevelStringCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPointCount(MultiLevelStringCache? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PointCount { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<Level>? GetLevels(MultiLevelStringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<Level>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Level>())
      {
        var newItem = LevelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetLevels(MultiLevelStringCache? openXmlElement, Collection<Level>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Level>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = LevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Level>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(MultiLevelStringCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(MultiLevelStringCache? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.MultiLevelStringCache? CreateModelElement(MultiLevelStringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.MultiLevelStringCache();
      value.PointCount = GetPointCount(openXmlElement);
      value.Levels = GetLevels(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.MultiLevelStringCache? value)
    where OpenXmlElementType : MultiLevelStringCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      SetLevels(openXmlElement, value?.Levels);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}