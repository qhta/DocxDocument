namespace DocumentModel.OpenXml.WebExtensions.UI;

/// <summary>
/// Defines the WebExtensionTaskpane Class.
/// </summary>
public static class WebExtensionTaskpaneConverter
{
  /// <summary>
  /// dockstate, this property is only available in Office 2013 and later.
  /// </summary>
  public static String? GetDockState(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.DockState?.Value;
  }
  
  public static void SetDockState(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DockState = new StringValue { Value = value };
      else
        openXmlElement.DockState = null;
  }
  
  /// <summary>
  /// visibility, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetVisibility(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Visibility?.Value;
  }
  
  public static void SetVisibility(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visibility = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visibility = null;
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  public static Double? GetWidth(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Width?.Value;
  }
  
  public static void SetWidth(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
      openXmlElement.Width = value;
  }
  
  /// <summary>
  /// row, this property is only available in Office 2013 and later.
  /// </summary>
  public static UInt32? GetRow(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Row?.Value;
  }
  
  public static void SetRow(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Row = value;
  }
  
  /// <summary>
  /// locked, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetLocked(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  public static void SetLocked(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Locked = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// WebExtensionPartReference.
  /// </summary>
  public static DocumentModel.WebExtensions.UI.WebExtensionPartReference? GetWebExtensionPartReference(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionPartReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.UI.WebExtensionPartReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWebExtensionPartReference(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, DocumentModel.WebExtensions.UI.WebExtensionPartReference? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.WebExtensions.UI.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.WebExtentionPane.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.WebExtensions.UI.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.WebExtentionPane.WebExtensionTaskpane? openXmlElement, DocumentModel.WebExtensions.UI.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
