using DocumentFormat.OpenXml.Office2013.WebExtentionPane;
using WebExtensionPartReference = DocumentModel.WebExtensions.UI.WebExtensionPartReference;

namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
///   Defines the WebExtensionTaskpane Class.
/// </summary>
public static class WebExtensionTaskpaneConverter
{
  /// <summary>
  ///   dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetDockState(WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.DockState?.Value;
  }

  public static void SetDockState(WebExtensionTaskpane? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DockState = new StringValue { Value = value };
      else
        openXmlElement.DockState = null;
  }

  /// <summary>
  ///   visibility, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetVisibility(WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Visibility?.Value;
  }

  public static void SetVisibility(WebExtensionTaskpane? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visibility = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visibility = null;
  }

  /// <summary>
  ///   width, this property is only available in Office 2013 and later.
  /// </summary>
  public static Double? GetWidth(WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }

  public static void SetWidth(WebExtensionTaskpane? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }

  /// <summary>
  ///   row, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetRow(WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Row?.Value;
  }

  public static void SetRow(WebExtensionTaskpane? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Row = value;
  }

  /// <summary>
  ///   locked, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetLocked(WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }

  public static void SetLocked(WebExtensionTaskpane? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Locked = null;
  }

  /// <summary>
  ///   WebExtensionPartReference.
  /// </summary>
  public static WebExtensionPartReference? GetWebExtensionPartReference(WebExtensionTaskpane? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
    if (itemElement != null)
      return WebExtensionPartReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWebExtensionPartReference(WebExtensionTaskpane? openXmlElement, WebExtensionPartReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebExtensionPartReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.WebExtensions.UI.OfficeArtExtensionList? GetOfficeArtExtensionList(WebExtensionTaskpane? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(WebExtensionTaskpane? openXmlElement, DocumentModel.WebExtensions.UI.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.WebExtensions.UI.WebExtensionTaskpane? CreateModelElement(WebExtensionTaskpane? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.WebExtensions.UI.WebExtensionTaskpane();
      value.DockState = GetDockState(openXmlElement);
      value.Visibility = GetVisibility(openXmlElement);
      value.Width = GetWidth(openXmlElement);
      value.Row = GetRow(openXmlElement);
      value.Locked = GetLocked(openXmlElement);
      value.WebExtensionPartReference = GetWebExtensionPartReference(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.WebExtensions.UI.WebExtensionTaskpane? value)
    where OpenXmlElementType : WebExtensionTaskpane, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDockState(openXmlElement, value?.DockState);
      SetVisibility(openXmlElement, value?.Visibility);
      SetWidth(openXmlElement, value?.Width);
      SetRow(openXmlElement, value?.Row);
      SetLocked(openXmlElement, value?.Locked);
      SetWebExtensionPartReference(openXmlElement, value?.WebExtensionPartReference);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}