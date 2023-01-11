namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Number Literal.
/// </summary>
public static class NumberLiteralConverter
{
  public static String? GetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FormatCode");
  }
  
  public static void SetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FormatCode");
  }
  
  public static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumericPoint>? GetNumericPoints(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetNumericPoints(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.NumericPoint>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
