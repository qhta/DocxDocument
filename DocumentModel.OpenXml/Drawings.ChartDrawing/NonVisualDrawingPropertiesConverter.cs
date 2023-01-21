namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Chart Non Visual Properties.
/// </summary>
public static class NonVisualDrawingPropertiesConverter
{
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  private static UInt32? GetId(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  private static String? GetName(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  private static String? GetDescription(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }
  
  private static void SetDescription(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Description = new StringValue { Value = value };
    else
      openXmlElement.Description = null;
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  private static Boolean? GetHidden(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static void SetHidden(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// Title
  /// </summary>
  private static String? GetTitle(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  private static DMDraws.HyperlinkOnClick? GetHyperlinkOnClick(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (itemElement != null)
      return DMXDraws.HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkOnClick(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnClick? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnClick>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnClickConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnClick>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  private static DMDraws.HyperlinkOnHover? GetHyperlinkOnHover(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.HyperlinkOnHover>();
    if (itemElement != null)
      return DMXDraws.HyperlinkOnHoverConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlinkOnHover(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, DMDraws.HyperlinkOnHover? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.HyperlinkOnHover>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.HyperlinkOnHoverConverter.CreateOpenXmlElement<DXDraw.HyperlinkOnHover>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  private static DMDraws.NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      return DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNonVisualDrawingPropertiesExtensionList(DXDrawChartDraw.NonVisualDrawingProperties openXmlElement, DMDraws.NonVisualDrawingPropertiesExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.NonVisualDrawingPropertiesExtensionListConverter.CreateOpenXmlElement<DXDraw.NonVisualDrawingPropertiesExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.NonVisualDrawingProperties? CreateModelElement(DXDrawChartDraw.NonVisualDrawingProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.NonVisualDrawingProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.NonVisualDrawingProperties? value)
    where OpenXmlElementType: DXDrawChartDraw.NonVisualDrawingProperties, new()
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
