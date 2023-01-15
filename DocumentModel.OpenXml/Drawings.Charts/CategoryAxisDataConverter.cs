using DocumentModel.Drawings.Charts;
using CategoryAxisData = DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the CategoryAxisData Class.
/// </summary>
public static class CategoryAxisDataConverter
{
  public static MultiLevelStringReference? GetMultiLevelStringReference(CategoryAxisData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
    if (itemElement != null)
      return MultiLevelStringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMultiLevelStringReference(CategoryAxisData? openXmlElement, MultiLevelStringReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MultiLevelStringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NumberReference? GetNumberReference(CategoryAxisData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      return NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberReference(CategoryAxisData? openXmlElement, NumberReference? value)
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

  public static NumberLiteral? GetNumberLiteral(CategoryAxisData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      return NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberLiteral(CategoryAxisData? openXmlElement, NumberLiteral? value)
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

  public static StringReference? GetStringReference(CategoryAxisData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      return StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringReference(CategoryAxisData? openXmlElement, StringReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static StringLiteral? GetStringLiteral(CategoryAxisData? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
    if (itemElement != null)
      return StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStringLiteral(CategoryAxisData? openXmlElement, StringLiteral? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.CategoryAxisData? CreateModelElement(CategoryAxisData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryAxisData();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryAxisData? value)
    where OpenXmlElementType : CategoryAxisData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      SetStringReference(openXmlElement, value?.StringReference);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}