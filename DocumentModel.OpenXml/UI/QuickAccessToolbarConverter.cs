using DocumentModel.UI;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  ///   SharedQatControls.
  /// </summary>
  public static SharedQatControls? GetSharedQatControls(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>();
    if (itemElement != null)
      return SharedQatControlsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSharedQatControls(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? openXmlElement, SharedQatControls? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SharedQatControlsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  public static DocumentSpecificQuickAccessToolbarControls? GetDocumentSpecificQuickAccessToolbarControls(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>();
    if (itemElement != null)
      return DocumentSpecificQuickAccessToolbarControlsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDocumentSpecificQuickAccessToolbarControls(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? openXmlElement, DocumentSpecificQuickAccessToolbarControls? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentSpecificQuickAccessToolbarControlsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.QuickAccessToolbar? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.QuickAccessToolbar();
      value.SharedQatControls = GetSharedQatControls(openXmlElement);
      value.DocumentSpecificQuickAccessToolbarControls = GetDocumentSpecificQuickAccessToolbarControls(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.QuickAccessToolbar? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSharedQatControls(openXmlElement, value?.SharedQatControls);
      SetDocumentSpecificQuickAccessToolbarControls(openXmlElement, value?.DocumentSpecificQuickAccessToolbarControls);
      return openXmlElement;
    }
    return default;
  }
}