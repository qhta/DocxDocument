using DocumentModel.Drawings.Charts;
using Layout = DocumentFormat.OpenXml.Drawing.Charts.Layout;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Layout.
/// </summary>
public static class LayoutConverter
{
  /// <summary>
  ///   Manual Layout.
  /// </summary>
  public static ManualLayout? GetManualLayout(Layout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
    if (itemElement != null)
      return ManualLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetManualLayout(Layout? openXmlElement, ManualLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ManualLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ManualLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(Layout? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Layout? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.Layout? CreateModelElement(Layout? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Layout();
      value.ManualLayout = GetManualLayout(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Layout? value)
    where OpenXmlElementType : Layout, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetManualLayout(openXmlElement, value?.ManualLayout);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}