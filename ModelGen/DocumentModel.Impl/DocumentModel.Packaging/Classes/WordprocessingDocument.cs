namespace DocumentModel.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public partial class WordprocessingDocumentImpl: DocumentModel.Packaging.OpenXmlPackageImpl, WordprocessingDocument
{
  public new DocumentFormat.OpenXml.Packaging.WordprocessingDocument? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.WordprocessingDocument?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public WordprocessingDocumentImpl(): base() {}
  
  public WordprocessingDocumentImpl(DocumentFormat.OpenXml.Packaging.WordprocessingDocument openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets the type of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.WordprocessingDocumentType? DocumentType
  {
    get => (DocumentModel.WordprocessingDocumentType?)OpenXmlElement?.DocumentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.WordprocessingDocument).GetProperty("DocumentType")?.SetValue(OpenXmlElement, (DocumentFormat.OpenXml.WordprocessingDocumentType?)value);
    }
  }
  
  public new DocumentModel.Packaging.OpenXmlPart? RootPart
  {
    get
    {
      if (OpenXmlElement?.RootPart != null)
        return new DocumentModel.Packaging.OpenXmlPartImpl(OpenXmlElement.RootPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the MainDocumentPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.MainDocumentPart? MainDocumentPart
  {
    get
    {
      if (OpenXmlElement?.MainDocumentPart != null)
        return new DocumentModel.Packaging.MainDocumentPartImpl(OpenXmlElement.MainDocumentPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the CoreFilePropertiesPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.CoreFilePropertiesPart? CoreFilePropertiesPart
  {
    get
    {
      if (OpenXmlElement?.CoreFilePropertiesPart != null)
        return new DocumentModel.Packaging.CoreFilePropertiesPartImpl(OpenXmlElement.CoreFilePropertiesPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ExtendedFilePropertiesPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.ExtendedFilePropertiesPart? ExtendedFilePropertiesPart
  {
    get
    {
      if (OpenXmlElement?.ExtendedFilePropertiesPart != null)
        return new DocumentModel.Packaging.ExtendedFilePropertiesPartImpl(OpenXmlElement.ExtendedFilePropertiesPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the CustomFilePropertiesPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.CustomFilePropertiesPart? CustomFilePropertiesPart
  {
    get
    {
      if (OpenXmlElement?.CustomFilePropertiesPart != null)
        return new DocumentModel.Packaging.CustomFilePropertiesPartImpl(OpenXmlElement.CustomFilePropertiesPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the ThumbnailPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.ThumbnailPart? ThumbnailPart
  {
    get
    {
      if (OpenXmlElement?.ThumbnailPart != null)
        return new DocumentModel.Packaging.ThumbnailPartImpl(OpenXmlElement.ThumbnailPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the DigitalSignatureOriginPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.DigitalSignatureOriginPart? DigitalSignatureOriginPart
  {
    get
    {
      if (OpenXmlElement?.DigitalSignatureOriginPart != null)
        return new DocumentModel.Packaging.DigitalSignatureOriginPartImpl(OpenXmlElement.DigitalSignatureOriginPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the RibbonExtensibilityPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.RibbonExtensibilityPart? RibbonExtensibilityPart
  {
    get
    {
      if (OpenXmlElement?.RibbonExtensibilityPart != null)
        return new DocumentModel.Packaging.RibbonExtensibilityPartImpl(OpenXmlElement.RibbonExtensibilityPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the QuickAccessToolbarCustomizationsPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.QuickAccessToolbarCustomizationsPart? QuickAccessToolbarCustomizationsPart
  {
    get
    {
      if (OpenXmlElement?.QuickAccessToolbarCustomizationsPart != null)
        return new DocumentModel.Packaging.QuickAccessToolbarCustomizationsPartImpl(OpenXmlElement.QuickAccessToolbarCustomizationsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the RibbonAndBackstageCustomizationsPart of the WordprocessingDocument, only available in Office2010.
  /// </summary>
  public DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart
  {
    get
    {
      if (OpenXmlElement?.RibbonAndBackstageCustomizationsPart != null)
        return new DocumentModel.Packaging.RibbonAndBackstageCustomizationsPartImpl(OpenXmlElement.RibbonAndBackstageCustomizationsPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the WebExTaskpanesPart of the WordprocessingDocument, only available in Office2013.
  /// </summary>
  public DocumentModel.Packaging.WebExTaskpanesPart? WebExTaskpanesPart
  {
    get
    {
      if (OpenXmlElement?.WebExTaskpanesPart != null)
        return new DocumentModel.Packaging.WebExTaskpanesPartImpl(OpenXmlElement.WebExTaskpanesPart);
      return null;
    }
  }
  
  /// <summary>
  /// Gets the LabelInfoPart of the WordprocessingDocument, only available in Office2021.
  /// </summary>
  public DocumentModel.Packaging.LabelInfoPart? LabelInfoPart
  {
    get
    {
      if (OpenXmlElement?.LabelInfoPart != null)
        return new DocumentModel.Packaging.LabelInfoPartImpl(OpenXmlElement.LabelInfoPart);
      return null;
    }
  }
  
}
