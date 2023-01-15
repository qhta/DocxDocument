using DocumentFormat.OpenXml.Drawing.Charts;
using DownBars = DocumentModel.Drawings.Charts.DownBars;
using UpBars = DocumentModel.Drawings.Charts.UpBars;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public static class UpDownBarsConverter
{
  /// <summary>
  ///   Gap Width.
  /// </summary>
  public static UInt16? GetGapWidth(UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<GapWidth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetGapWidth(UpDownBars? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<GapWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new GapWidth { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Up Bars.
  /// </summary>
  public static UpBars? GetUpBars(UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpBars>();
    if (itemElement != null)
      return UpBarsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetUpBars(UpDownBars? openXmlElement, UpBars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.UpBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.UpBars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Down Bars.
  /// </summary>
  public static DownBars? GetDownBars(UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DownBars>();
    if (itemElement != null)
      return DownBarsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDownBars(UpDownBars? openXmlElement, DownBars? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DownBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DownBarsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DownBars>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(UpDownBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(UpDownBars? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.UpDownBars? CreateModelElement(UpDownBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.UpDownBars();
      value.GapWidth = GetGapWidth(openXmlElement);
      value.UpBars = GetUpBars(openXmlElement);
      value.DownBars = GetDownBars(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.UpDownBars? value)
    where OpenXmlElementType : UpDownBars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGapWidth(openXmlElement, value?.GapWidth);
      SetUpBars(openXmlElement, value?.UpBars);
      SetDownBars(openXmlElement, value?.DownBars);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}