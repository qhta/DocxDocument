using DocumentModel.Drawings;
using ShapeStyle = DocumentFormat.OpenXml.Drawing.ShapeStyle;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Style.
/// </summary>
public static class ShapeStyleConverter
{
  /// <summary>
  ///   LineReference.
  /// </summary>
  public static LineReference? GetLineReference(ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineReference>();
    if (itemElement != null)
      return LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineReference(ShapeStyle? openXmlElement, LineReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FillReference.
  /// </summary>
  public static FillReference? GetFillReference(ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillReference>();
    if (itemElement != null)
      return FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillReference(ShapeStyle? openXmlElement, FillReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   EffectReference.
  /// </summary>
  public static EffectReference? GetEffectReference(ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
    if (itemElement != null)
      return EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectReference(ShapeStyle? openXmlElement, EffectReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Font Reference.
  /// </summary>
  public static FontReference? GetFontReference(ShapeStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontReference>();
    if (itemElement != null)
      return FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFontReference(ShapeStyle? openXmlElement, FontReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FontReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FontReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ShapeStyle? CreateModelElement(ShapeStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ShapeStyle();
      value.LineReference = GetLineReference(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ShapeStyle? value)
    where OpenXmlElementType : ShapeStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineReference(openXmlElement, value?.LineReference);
      SetFillReference(openXmlElement, value?.FillReference);
      SetEffectReference(openXmlElement, value?.EffectReference);
      SetFontReference(openXmlElement, value?.FontReference);
      return openXmlElement;
    }
    return default;
  }
}