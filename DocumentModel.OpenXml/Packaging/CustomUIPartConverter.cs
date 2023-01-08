namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
/// </summary>
public static class CustomUIPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.UI.CustomUI? GetCustomUI(DocumentFormat.OpenXml.Packaging.CustomUIPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomUI(DocumentFormat.OpenXml.Packaging.CustomUIPart? openXmlElement, DocumentModel.UI.CustomUI? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
