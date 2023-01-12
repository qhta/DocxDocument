namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ColorScheme Class.
/// </summary>
public static class ColorSchemeConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Dark 1.
  /// </summary>
  public static DocumentModel.Drawings.Dark1Color? GetDark1Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Dark1Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Dark1ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDark1Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Dark1Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Dark1Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Dark1ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Dark1Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Light 1.
  /// </summary>
  public static DocumentModel.Drawings.Light1Color? GetLight1Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Light1Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Light1ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLight1Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Light1Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Light1Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Light1ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Light1Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Dark 2.
  /// </summary>
  public static DocumentModel.Drawings.Dark2Color? GetDark2Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Dark2Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Dark2ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDark2Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Dark2Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Dark2Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Dark2ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Dark2Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Light 2.
  /// </summary>
  public static DocumentModel.Drawings.Light2Color? GetLight2Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Light2Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Light2ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLight2Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Light2Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Light2Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Light2ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Light2Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Accent 1.
  /// </summary>
  public static DocumentModel.Drawings.Accent1Color? GetAccent1Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent1Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Accent1ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent1Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Accent1Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent1Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Accent1ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Accent1Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Accent 2.
  /// </summary>
  public static DocumentModel.Drawings.Accent2Color? GetAccent2Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent2Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Accent2ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent2Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Accent2Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent2Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Accent2ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Accent2Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Accent 3.
  /// </summary>
  public static DocumentModel.Drawings.Accent3Color? GetAccent3Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent3Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Accent3ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent3Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Accent3Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent3Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Accent3ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Accent3Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Accent 4.
  /// </summary>
  public static DocumentModel.Drawings.Accent4Color? GetAccent4Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent4Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Accent4ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent4Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Accent4Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent4Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Accent4ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Accent4Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Accent 5.
  /// </summary>
  public static DocumentModel.Drawings.Accent5Color? GetAccent5Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent5Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Accent5ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent5Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Accent5Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent5Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Accent5ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Accent5Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Accent 6.
  /// </summary>
  public static DocumentModel.Drawings.Accent6Color? GetAccent6Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent6Color>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Accent6ColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAccent6Color(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Accent6Color? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Accent6Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Accent6ColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Accent6Color>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Hyperlink.
  /// </summary>
  public static DocumentModel.Drawings.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hyperlink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.Hyperlink? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Hyperlink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HyperlinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Hyperlink>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  public static DocumentModel.Drawings.FollowedHyperlinkColor? GetFollowedHyperlinkColor(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.FollowedHyperlinkColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFollowedHyperlinkColor(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.FollowedHyperlinkColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.FollowedHyperlinkColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ColorScheme? CreateModelElement(DocumentFormat.OpenXml.Drawing.ColorScheme? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ColorScheme();
      value.Name = GetName(openXmlElement);
      value.Dark1Color = GetDark1Color(openXmlElement);
      value.Light1Color = GetLight1Color(openXmlElement);
      value.Dark2Color = GetDark2Color(openXmlElement);
      value.Light2Color = GetLight2Color(openXmlElement);
      value.Accent1Color = GetAccent1Color(openXmlElement);
      value.Accent2Color = GetAccent2Color(openXmlElement);
      value.Accent3Color = GetAccent3Color(openXmlElement);
      value.Accent4Color = GetAccent4Color(openXmlElement);
      value.Accent5Color = GetAccent5Color(openXmlElement);
      value.Accent6Color = GetAccent6Color(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.FollowedHyperlinkColor = GetFollowedHyperlinkColor(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ColorScheme? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ColorScheme, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetDark1Color(openXmlElement, value?.Dark1Color);
      SetLight1Color(openXmlElement, value?.Light1Color);
      SetDark2Color(openXmlElement, value?.Dark2Color);
      SetLight2Color(openXmlElement, value?.Light2Color);
      SetAccent1Color(openXmlElement, value?.Accent1Color);
      SetAccent2Color(openXmlElement, value?.Accent2Color);
      SetAccent3Color(openXmlElement, value?.Accent3Color);
      SetAccent4Color(openXmlElement, value?.Accent4Color);
      SetAccent5Color(openXmlElement, value?.Accent5Color);
      SetAccent6Color(openXmlElement, value?.Accent6Color);
      SetHyperlink(openXmlElement, value?.Hyperlink);
      SetFollowedHyperlinkColor(openXmlElement, value?.FollowedHyperlinkColor);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
