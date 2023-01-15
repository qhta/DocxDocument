using DocumentFormat.OpenXml.Drawing.Diagrams;
using EffectColorList = DocumentModel.Drawings.Diagrams.EffectColorList;
using FillColorList = DocumentModel.Drawings.Diagrams.FillColorList;
using LineColorList = DocumentModel.Drawings.Diagrams.LineColorList;
using TextEffectColorList = DocumentModel.Drawings.Diagrams.TextEffectColorList;
using TextFillColorList = DocumentModel.Drawings.Diagrams.TextFillColorList;
using TextLineColorList = DocumentModel.Drawings.Diagrams.TextLineColorList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Style Label.
/// </summary>
public static class ColorTransformStyleLabelConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(ColorTransformStyleLabel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(ColorTransformStyleLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Fill Color List.
  /// </summary>
  public static FillColorList? GetFillColorList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>();
    if (itemElement != null)
      return FillColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillColorList(ColorTransformStyleLabel? openXmlElement, FillColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Line Color List.
  /// </summary>
  public static LineColorList? GetLineColorList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>();
    if (itemElement != null)
      return LineColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineColorList(ColorTransformStyleLabel? openXmlElement, LineColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Effect Color List.
  /// </summary>
  public static EffectColorList? GetEffectColorList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>();
    if (itemElement != null)
      return EffectColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectColorList(ColorTransformStyleLabel? openXmlElement, EffectColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Line Color List.
  /// </summary>
  public static TextLineColorList? GetTextLineColorList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>();
    if (itemElement != null)
      return TextLineColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextLineColorList(ColorTransformStyleLabel? openXmlElement, TextLineColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextLineColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Fill Color List.
  /// </summary>
  public static TextFillColorList? GetTextFillColorList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>();
    if (itemElement != null)
      return TextFillColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextFillColorList(ColorTransformStyleLabel? openXmlElement, TextFillColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextFillColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Effect Color List.
  /// </summary>
  public static TextEffectColorList? GetTextEffectColorList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>();
    if (itemElement != null)
      return TextEffectColorListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextEffectColorList(ColorTransformStyleLabel? openXmlElement, TextEffectColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextEffectColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel? CreateModelElement(ColorTransformStyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel();
      value.Name = GetName(openXmlElement);
      value.FillColorList = GetFillColorList(openXmlElement);
      value.LineColorList = GetLineColorList(openXmlElement);
      value.EffectColorList = GetEffectColorList(openXmlElement);
      value.TextLineColorList = GetTextLineColorList(openXmlElement);
      value.TextFillColorList = GetTextFillColorList(openXmlElement);
      value.TextEffectColorList = GetTextEffectColorList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel? value)
    where OpenXmlElementType : ColorTransformStyleLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillColorList(openXmlElement, value?.FillColorList);
      SetLineColorList(openXmlElement, value?.LineColorList);
      SetEffectColorList(openXmlElement, value?.EffectColorList);
      SetTextLineColorList(openXmlElement, value?.TextLineColorList);
      SetTextFillColorList(openXmlElement, value?.TextFillColorList);
      SetTextEffectColorList(openXmlElement, value?.TextEffectColorList);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}