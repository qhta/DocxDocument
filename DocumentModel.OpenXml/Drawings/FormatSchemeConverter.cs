using DocumentFormat.OpenXml.Drawing;
using BackgroundFillStyleList = DocumentModel.Drawings.BackgroundFillStyleList;
using EffectStyleList = DocumentModel.Drawings.EffectStyleList;
using FillStyleList = DocumentModel.Drawings.FillStyleList;
using LineStyleList = DocumentModel.Drawings.LineStyleList;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Format Scheme.
/// </summary>
public static class FormatSchemeConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(FormatScheme? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(FormatScheme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Fill Style List.
  /// </summary>
  public static FillStyleList? GetFillStyleList(FormatScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillStyleList>();
    if (itemElement != null)
      return FillStyleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFillStyleList(FormatScheme? openXmlElement, FillStyleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FillStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FillStyleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Line Style List.
  /// </summary>
  public static LineStyleList? GetLineStyleList(FormatScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineStyleList>();
    if (itemElement != null)
      return LineStyleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineStyleList(FormatScheme? openXmlElement, LineStyleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineStyleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Effect Style List.
  /// </summary>
  public static EffectStyleList? GetEffectStyleList(FormatScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyleList>();
    if (itemElement != null)
      return EffectStyleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEffectStyleList(FormatScheme? openXmlElement, EffectStyleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectStyleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Background Fill Style List.
  /// </summary>
  public static BackgroundFillStyleList? GetBackgroundFillStyleList(FormatScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>();
    if (itemElement != null)
      return BackgroundFillStyleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundFillStyleList(FormatScheme? openXmlElement, BackgroundFillStyleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundFillStyleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.FormatScheme? CreateModelElement(FormatScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FormatScheme();
      value.Name = GetName(openXmlElement);
      value.FillStyleList = GetFillStyleList(openXmlElement);
      value.LineStyleList = GetLineStyleList(openXmlElement);
      value.EffectStyleList = GetEffectStyleList(openXmlElement);
      value.BackgroundFillStyleList = GetBackgroundFillStyleList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FormatScheme? value)
    where OpenXmlElementType : FormatScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetFillStyleList(openXmlElement, value?.FillStyleList);
      SetLineStyleList(openXmlElement, value?.LineStyleList);
      SetEffectStyleList(openXmlElement, value?.EffectStyleList);
      SetBackgroundFillStyleList(openXmlElement, value?.BackgroundFillStyleList);
      return openXmlElement;
    }
    return default;
  }
}