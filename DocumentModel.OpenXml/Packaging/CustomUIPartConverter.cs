using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and
///   QuickAccessToolbarCustomizationsPart.
/// </summary>
public static class CustomUIPartConverter
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.UI.CustomUI? GetCustomUI(CustomUIPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.CustomUI.CustomUI rootElement)
      return UI.CustomUIConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetCustomUI(CustomUIPart? openXmlElement, DocumentModel.UI.CustomUI? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = UI.CustomUIConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.CustomUI>(value);
        if (rootElement != null)
          openXmlElement.CustomUI = rootElement;
      }
  }

  public static DocumentModel.Packaging.CustomUIPart? CreateModelElement(CustomUIPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomUIPart();
      value.CustomUI = GetCustomUI(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomUIPart? value)
    where OpenXmlElementType : CustomUIPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomUI(openXmlElement, value?.CustomUI);
      return openXmlElement;
    }
    return default;
  }
}