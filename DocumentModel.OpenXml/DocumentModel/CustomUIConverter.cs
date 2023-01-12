namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CustomUI Class.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  /// onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnLoad(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    return openXmlElement?.OnLoad?.Value;
  }
  
  public static void SetOnLoad(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnLoad = new StringValue { Value = value };
      else
        openXmlElement.OnLoad = null;
  }
  
  /// <summary>
  /// loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLoadImage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    return openXmlElement?.LoadImage?.Value;
  }
  
  public static void SetLoadImage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.LoadImage = new StringValue { Value = value };
      else
        openXmlElement.LoadImage = null;
  }
  
  /// <summary>
  /// Commands.
  /// </summary>
  public static DocumentModel.Commands? GetCommands(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
    if (itemElement != null)
      return DocumentModel.OpenXml.CommandsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCommands(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, DocumentModel.Commands? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.CommandsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  public static DocumentModel.Ribbon? GetRibbon(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
    if (itemElement != null)
      return DocumentModel.OpenXml.RibbonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRibbon(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, DocumentModel.Ribbon? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.RibbonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Backstage.
  /// </summary>
  public static DocumentModel.Backstage? GetBackstage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstage(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, DocumentModel.Backstage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ContextMenus.
  /// </summary>
  public static DocumentModel.ContextMenus? GetContextMenus(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ContextMenusConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetContextMenus(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement, DocumentModel.ContextMenus? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ContextMenusConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.CustomUI? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomUI();
      value.OnLoad = GetOnLoad(openXmlElement);
      value.LoadImage = GetLoadImage(openXmlElement);
      value.Commands = GetCommands(openXmlElement);
      value.Ribbon = GetRibbon(openXmlElement);
      value.Backstage = GetBackstage(openXmlElement);
      value.ContextMenus = GetContextMenus(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.CustomUI? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnLoad(openXmlElement, value?.OnLoad);
      SetLoadImage(openXmlElement, value?.LoadImage);
      SetCommands(openXmlElement, value?.Commands);
      SetRibbon(openXmlElement, value?.Ribbon);
      SetBackstage(openXmlElement, value?.Backstage);
      SetContextMenus(openXmlElement, value?.ContextMenus);
      return openXmlElement;
    }
    return default;
  }
}
