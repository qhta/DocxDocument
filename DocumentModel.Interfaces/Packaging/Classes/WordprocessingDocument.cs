namespace DocumentModel.Packaging;

/// <summary>
///   Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public interface WordprocessingDocument
{
  /// <summary>
  ///   Gets the type of the WordprocessingDocument.
  /// </summary>
  public WordprocessingDocumentType? DocumentType { get; set; }
}