namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Literal.
/// </summary>
public static class StringLiteralConverter
{
  private static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral openXmlElement, UInt32? value)
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
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint> GetStringPoints(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral openXmlElement)
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
  
  private static void SetStringPoints(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.StringPoint>? value)
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
  
  private static DocumentModel.Drawings.Charts.StrDataExtensionList? GetStrDataExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StrDataExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStrDataExtensionList(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral openXmlElement, DocumentModel.Drawings.Charts.StrDataExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.StringLiteral? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StringLiteral? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringLiteral();
      value.PointCount = GetPointCount(openXmlElement);
      value.StringPoints = GetStringPoints(openXmlElement);
      value.StrDataExtensionList = GetStrDataExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringLiteral? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StringLiteral, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPointCount(openXmlElement, value?.PointCount);
      SetStringPoints(openXmlElement, value?.StringPoints);
      SetStrDataExtensionList(openXmlElement, value?.StrDataExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
