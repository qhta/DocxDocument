using DocumentModel.Drawings.Charts;
using YValues = DocumentFormat.OpenXml.Drawing.Charts.YValues;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the YValues Class.
/// </summary>
public static class YValuesConverter
{
  public static NumberReference? GetNumberReference(YValues? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      return NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberReference(YValues? openXmlElement, NumberReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NumberLiteral? GetNumberLiteral(YValues? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      return NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberLiteral(YValues? openXmlElement, NumberLiteral? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.YValues? CreateModelElement(YValues? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.YValues();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.YValues? value)
    where OpenXmlElementType : YValues, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      return openXmlElement;
    }
    return default;
  }
}