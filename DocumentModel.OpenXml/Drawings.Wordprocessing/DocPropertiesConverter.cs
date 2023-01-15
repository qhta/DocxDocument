using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
///   Drawing Object Non-Visual Properties.
/// </summary>
public static class DocPropertiesConverter
{
  /// <summary>
  ///   Application defined unique identifier.
  /// </summary>
  public static UInt32? GetId(DocProperties? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocProperties? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   Name compatible with Object Model (non-unique).
  /// </summary>
  public static String? GetName(DocProperties? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(DocProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Description of the drawing element.
  /// </summary>
  public static String? GetDescription(DocProperties? openXmlElement)
  {
    return openXmlElement?.Description?.Value;
  }

  public static void SetDescription(DocProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Description = new StringValue { Value = value };
      else
        openXmlElement.Description = null;
  }

  /// <summary>
  ///   Flag determining to show or hide this element.
  /// </summary>
  public static Boolean? GetHidden(DocProperties? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }

  public static void SetHidden(DocProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }

  /// <summary>
  ///   Title
  /// </summary>
  public static String? GetTitle(DocProperties? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }

  public static void SetTitle(DocProperties? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }

  /// <summary>
  ///   Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public static HyperlinkOnClick? GetHyperlinkOnClick(DocProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
    if (itemElement != null)
      return HyperlinkOnClickConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkOnClick(DocProperties? openXmlElement, HyperlinkOnClick? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnClickConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Hyperlink associated with hovering over the element..
  /// </summary>
  public static HyperlinkOnHover? GetHyperlinkOnHover(DocProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
    if (itemElement != null)
      return HyperlinkOnHoverConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlinkOnHover(DocProperties? openXmlElement, HyperlinkOnHover? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnHoverConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Future extension.
  /// </summary>
  public static NonVisualDrawingPropertiesExtensionList? GetNonVisualDrawingPropertiesExtensionList(DocProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
    if (itemElement != null)
      return NonVisualDrawingPropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNonVisualDrawingPropertiesExtensionList(DocProperties? openXmlElement, NonVisualDrawingPropertiesExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Wordprocessing.DocProperties? CreateModelElement(DocProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.DocProperties();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Wordprocessing.DocProperties? value)
    where OpenXmlElementType : DocProperties, new()
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