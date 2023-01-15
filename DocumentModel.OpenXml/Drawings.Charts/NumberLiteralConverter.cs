using DocumentFormat.OpenXml.Drawing.Charts;
using NumericPoint = DocumentModel.Drawings.Charts.NumericPoint;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Number Literal.
/// </summary>
public static class NumberLiteralConverter
{
  public static String? GetFormatCode(NumberLiteral? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FormatCode>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetFormatCode(NumberLiteral? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FormatCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FormatCode { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt32? GetPointCount(NumberLiteral? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PointCount>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPointCount(NumberLiteral? openXmlElement, UInt32? value)
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

  public static Collection<NumericPoint>? GetNumericPoints(NumberLiteral? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<NumericPoint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>())
      {
        var newItem = NumericPointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetNumericPoints(NumberLiteral? openXmlElement, Collection<NumericPoint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = NumericPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumericPoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(NumberLiteral? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(NumberLiteral? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.NumberLiteral? CreateModelElement(NumberLiteral? openXmlElement)
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
    where OpenXmlElementType : NumberLiteral, new()
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