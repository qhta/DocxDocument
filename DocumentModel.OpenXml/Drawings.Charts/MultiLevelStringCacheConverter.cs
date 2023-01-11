namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the MultiLevelStringCache Class.
/// </summary>
public static class MultiLevelStringCacheConverter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Level>? GetLevels(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Level>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.Level>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.LevelConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetLevels(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.Level>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.Level>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.LevelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Level>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.MultiLevelStringCache? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringCache, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
