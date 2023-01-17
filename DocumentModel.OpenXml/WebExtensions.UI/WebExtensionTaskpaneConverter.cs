namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionTaskpane Class.
/// </summary>
public static class WebExtensionTaskpaneConverter
{
  /// <summary>
  /// dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetDockState(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.DockState?.Value;
  }
  
  private static void SetDockState(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.DockState = new StringValue { Value = value };
    else
      openXmlElement.DockState = null;
  }
  
  /// <summary>
  /// visibility, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetVisibility(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Visibility?.Value;
  }
  
  private static void SetVisibility(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visibility = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visibility = null;
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  private static Double? GetWidth(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, Double? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// row, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetRow(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement.Row?.Value;
  }
  
  private static void SetRow(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, UInt32? value)
  {
    openXmlElement.Row = value;
  }
  
  /// <summary>
  /// locked, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetLocked(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static void SetLocked(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// WebExtensionPartReference.
  /// </summary>
  private static DocumentModel.WebExtensions.UI.WebExtensionPartReference? GetWebExtensionPartReference(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.UI.WebExtensionPartReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWebExtensionPartReference(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, DocumentModel.WebExtensions.UI.WebExtensionPartReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.WebExtensions.UI.WebExtensionPartReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DocumentModel.WebExtensions.UI.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.UI.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane openXmlElement, DocumentModel.WebExtensions.UI.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.WebExtensions.UI.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.WebExtensions.UI.WebExtensionTaskpane? CreateModelElement(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane, new()
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
