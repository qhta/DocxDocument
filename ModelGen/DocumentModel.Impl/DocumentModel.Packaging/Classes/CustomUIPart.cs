namespace DocumentModel.Packaging;

/// <summary>
/// Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
/// </summary>
public partial class CustomUIPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, CustomUIPart
{
  public new DocumentFormat.OpenXml.Packaging.CustomUIPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.CustomUIPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CustomUIPartImpl(): base() {}
  
  public CustomUIPartImpl(DocumentFormat.OpenXml.Packaging.CustomUIPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.UI.CustomUI? CustomUI
  {
    get
    {
      if (OpenXmlElement?.CustomUI != null)
        return new DocumentModel.UI.CustomUIImpl(OpenXmlElement.CustomUI);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.UI.CustomUIImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.CustomUI = valueImpl.OpenXmlElement;
    }
  }
  
}
