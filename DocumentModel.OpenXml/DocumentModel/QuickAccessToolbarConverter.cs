namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  /// SharedControlsQatItems.
  /// </summary>
  private static DocumentModel.SharedControlsQatItems? GetSharedControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SharedControlsQatItemsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSharedControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar openXmlElement, DocumentModel.SharedControlsQatItems? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.SharedControlsQatItemsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DocumentControlsQatItems.
  /// </summary>
  private static DocumentModel.DocumentControlsQatItems? GetDocumentControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
    if (itemElement != null)
      return DocumentModel.OpenXml.DocumentControlsQatItemsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocumentControlsQatItems(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar openXmlElement, DocumentModel.DocumentControlsQatItems? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.DocumentControlsQatItemsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.QuickAccessToolbar? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.QuickAccessToolbar();
      value.SharedControlsQatItems = GetSharedControlsQatItems(openXmlElement);
      value.DocumentControlsQatItems = GetDocumentControlsQatItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.QuickAccessToolbar? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar, new()
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
