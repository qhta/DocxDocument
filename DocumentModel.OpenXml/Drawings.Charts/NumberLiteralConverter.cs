namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Literal.
/// </summary>
public static class NumberLiteralConverter
{
  private static String? GetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.FormatCode { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement, UInt32? value)
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
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumericPoint> GetNumericPoints(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumericPoint>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.NumericPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNumericPoints(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumericPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.NumericPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.Charts.NumberLiteral? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberLiteral();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      value.NumericPoints = GetNumericPoints(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberLiteral? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetPointCount(openXmlElement, value?.PointCount);
      SetNumericPoints(openXmlElement, value?.NumericPoints);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
