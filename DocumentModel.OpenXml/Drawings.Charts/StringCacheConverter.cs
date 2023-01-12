namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public static class StringCacheConverter
{
  public static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.Charts.PointCount{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint>? GetStringPoints(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.StringPointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetStringPoints(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.StringPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringPoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StrDataExtensionList? GetStrDataExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StrDataExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStrDataExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement, DocumentModel.Drawings.Charts.StrDataExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.StrDataExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.StringCache? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StringCache? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringCache();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringCache? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StringCache, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
