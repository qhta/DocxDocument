using DocumentModel.Drawings.Charts;
using ChartSpaceExtension = DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension;
using PivotSource = DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ChartSpaceExtension Class.
/// </summary>
public static class ChartSpaceExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(ChartSpaceExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(ChartSpaceExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static PivotOptions? GetPivotOptions(ChartSpaceExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
    if (itemElement != null)
      return PivotOptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPivotOptions(ChartSpaceExtension? openXmlElement, PivotOptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SketchOptions? GetSketchOptions(ChartSpaceExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
    if (itemElement != null)
      return SketchOptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSketchOptions(ChartSpaceExtension? openXmlElement, SketchOptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SketchOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PivotSource3? GetPivotSource(ChartSpaceExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PivotSource>();
    if (itemElement != null)
      return PivotSource3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPivotSource(ChartSpaceExtension? openXmlElement, PivotSource3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PivotSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotSource3Converter.CreateOpenXmlElement<PivotSource>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ChartSpaceExtension? CreateModelElement(ChartSpaceExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtension();
      value.Uri = GetUri(openXmlElement);
      value.PivotOptions = GetPivotOptions(openXmlElement);
      value.SketchOptions = GetSketchOptions(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartSpaceExtension? value)
    where OpenXmlElementType : ChartSpaceExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetPivotOptions(openXmlElement, value?.PivotOptions);
      SetSketchOptions(openXmlElement, value?.SketchOptions);
      SetPivotSource(openXmlElement, value?.PivotSource);
      return openXmlElement;
    }
    return default;
  }
}