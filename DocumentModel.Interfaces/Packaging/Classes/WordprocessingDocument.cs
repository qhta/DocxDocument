namespace DocumentModel.Packaging;

/// <summary>
///   Defines WordprocessingDocument - an OpenXmlPackage represents a Word document.
/// </summary>
public class WordprocessingDocument: ModelElement
{
  /// <summary>
  ///   Gets the type of the WordprocessingDocument.
  /// </summary>
  public WordprocessingDocumentType? DocumentType { get; set; }
}