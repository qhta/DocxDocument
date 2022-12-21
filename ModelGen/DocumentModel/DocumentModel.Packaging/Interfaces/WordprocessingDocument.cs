namespace DocumentModel.Packaging;

/// <summary>
/// Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public partial interface WordprocessingDocument
{
  /// <summary>
  /// Gets the type of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.WordprocessingDocumentType? DocumentType { get; set; }
  
  /// <summary>
  /// Gets the MainDocumentPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.MainDocumentPart? MainDocumentPart { get; }
  
  /// <summary>
  /// Gets the CoreFilePropertiesPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.CoreFilePropertiesPart? CoreFilePropertiesPart { get; }
  
  /// <summary>
  /// Gets the ExtendedFilePropertiesPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.ExtendedFilePropertiesPart? ExtendedFilePropertiesPart { get; }
  
  /// <summary>
  /// Gets the CustomFilePropertiesPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.CustomFilePropertiesPart? CustomFilePropertiesPart { get; }
  
  /// <summary>
  /// Gets the ThumbnailPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.ThumbnailPart? ThumbnailPart { get; }
  
  /// <summary>
  /// Gets the DigitalSignatureOriginPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.DigitalSignatureOriginPart? DigitalSignatureOriginPart { get; }
  
  /// <summary>
  /// Gets the RibbonExtensibilityPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.RibbonExtensibilityPart? RibbonExtensibilityPart { get; }
  
  /// <summary>
  /// Gets the QuickAccessToolbarCustomizationsPart of the WordprocessingDocument.
  /// </summary>
  public DocumentModel.Packaging.QuickAccessToolbarCustomizationsPart? QuickAccessToolbarCustomizationsPart { get; }
  
  /// <summary>
  /// Gets the RibbonAndBackstageCustomizationsPart of the WordprocessingDocument, only available in Office2010.
  /// </summary>
  public DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart { get; }
  
  /// <summary>
  /// Gets the WebExTaskpanesPart of the WordprocessingDocument, only available in Office2013.
  /// </summary>
  public DocumentModel.Packaging.WebExTaskpanesPart? WebExTaskpanesPart { get; }
  
  /// <summary>
  /// Gets the LabelInfoPart of the WordprocessingDocument, only available in Office2021.
  /// </summary>
  public DocumentModel.Packaging.LabelInfoPart? LabelInfoPart { get; }
  
}
