namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  ///   SharedControlsQatItems.
  /// </summary>
  public static SharedControlsQatItems? GetSharedControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
    if (itemElement != null)
      return SharedControlsQatItemsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSharedControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? openXmlElement, SharedControlsQatItems? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SharedControlsQatItemsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DocumentControlsQatItems.
  /// </summary>
  public static DocumentControlsQatItems? GetDocumentControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
    if (itemElement != null)
      return DocumentControlsQatItemsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocumentControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? openXmlElement, DocumentControlsQatItems? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentControlsQatItemsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static QuickAccessToolbar? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new QuickAccessToolbar();
      value.SharedControlsQatItems = GetSharedControlsQatItems(openXmlElement);
      value.DocumentControlsQatItems = GetDocumentControlsQatItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(QuickAccessToolbar? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSharedControlsQatItems(openXmlElement, value?.SharedControlsQatItems);
      SetDocumentControlsQatItems(openXmlElement, value?.DocumentControlsQatItems);
      return openXmlElement;
    }
    return default;
  }
}