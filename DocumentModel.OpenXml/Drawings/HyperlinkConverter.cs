using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Hyperlink.
/// </summary>
public static class HyperlinkConverter
{
  public static RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement, RgbColorModelPercentage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelPercentageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement, RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HslColor? GetHslColor(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return HslColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHslColor(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement, HslColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HslColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HslColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SystemColor? GetSystemColor(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSystemColor(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement, SystemColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SystemColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SystemColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PresetColor? GetPresetColor(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresetColor(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement, PresetColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Hyperlink? CreateModelElement(DocumentFormat.OpenXml.Drawing.Hyperlink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Hyperlink();
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Hyperlink? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Drawing.Hyperlink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      return openXmlElement;
    }
    return default;
  }
}