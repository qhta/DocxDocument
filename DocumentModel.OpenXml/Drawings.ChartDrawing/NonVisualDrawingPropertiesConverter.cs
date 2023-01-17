namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Chart Non Visual Properties.
/// </summary>
public static class NonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  private static UInt32? GetId(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  private static String? GetDescription(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static void SetDescription(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  private static Boolean? GetHidden(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static void SetHidden(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  private static DocumentModel.Drawings.HyperlinkOnClick? GetHyperlinkOnClick(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkOnClick(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, DocumentModel.Drawings.HyperlinkOnClick? value)
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
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  private static DocumentModel.Drawings.HyperlinkOnHover? GetHyperlinkOnHover(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkOnHoverConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkOnHover(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, DocumentModel.Drawings.HyperlinkOnHover? value)
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
  
  /// <summary>
  /// Future extension.
  /// </summary>
  private static DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingPropertiesExtensionList(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties openXmlElement, DocumentModel.Drawings.NonVisualDrawingPropertiesExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualDrawingProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualDrawingProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetName(openXmlElement, value?.Name);
      SetDescription(openXmlElement, value?.Description);
      SetHidden(openXmlElement, value?.Hidden);
      SetTitle(openXmlElement, value?.Title);
      SetHyperlinkOnClick(openXmlElement, value?.HyperlinkOnClick);
      SetHyperlinkOnHover(openXmlElement, value?.HyperlinkOnHover);
      SetNonVisualDrawingPropertiesExtensionList(openXmlElement, value?.NonVisualDrawingPropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
