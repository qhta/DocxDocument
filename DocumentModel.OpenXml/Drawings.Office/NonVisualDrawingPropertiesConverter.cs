namespace DocumentModel.OpenXml.Drawings.Office;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public static class NonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  public static UInt32? GetId(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  public static String? GetDescription(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  public static void SetDescription(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public static DocumentModel.Drawings.HyperlinkOnClick? GetHyperlinkOnClick(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlinkOnClick(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, DocumentModel.Drawings.HyperlinkOnClick? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HyperlinkOnClickConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public static DocumentModel.Drawings.HyperlinkOnHover? GetHyperlinkOnHover(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkOnHoverConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlinkOnHover(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, DocumentModel.Drawings.HyperlinkOnHover? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HyperlinkOnHoverConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetNonVisualDrawingPropertiesExtensionList(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement, DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.NonVisualDrawingPropertiesExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Office.NonVisualDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.NonVisualDrawingProperties();
      value.Id = GetId(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.Description = GetDescription(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.HyperlinkOnClick = GetHyperlinkOnClick(openXmlElement);
      value.HyperlinkOnHover = GetHyperlinkOnHover(openXmlElement);
      value.NonVisualDrawingPropertiesExtensionList = GetNonVisualDrawingPropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.NonVisualDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
