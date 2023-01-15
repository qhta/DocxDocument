using DocumentModel.Drawings.Charts;
using NumberDataSourceType = DocumentFormat.OpenXml.Drawing.Charts.NumberDataSourceType;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the NumberDataSourceType Class.
/// </summary>
public static class NumberDataSourceTypeConverter
{
  /// <summary>
  ///   Number Reference.
  /// </summary>
  public static NumberReference? GetNumberReference(NumberDataSourceType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      return NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberReference(NumberDataSourceType? openXmlElement, NumberReference? value)
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

  /// <summary>
  ///   Number Literal.
  /// </summary>
  public static NumberLiteral? GetNumberLiteral(NumberDataSourceType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      return NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberLiteral(NumberDataSourceType? openXmlElement, NumberLiteral? value)
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

  public static DocumentModel.Drawings.Charts.NumberDataSourceType? CreateModelElement(NumberDataSourceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberDataSourceType();
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberDataSourceType? value)
    where OpenXmlElementType : NumberDataSourceType, new()
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