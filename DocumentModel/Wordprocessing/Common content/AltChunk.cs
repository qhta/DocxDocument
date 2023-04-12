namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a location within a document for the insertion of the contents 
///   of a specified file containing external content to be imported into the main WordprocessingML document. 
///   The specified file's contents should appear at the specified location within the document, 
///   and can henceforth be emitted as regular WordprocessingML without distinction to its origin. 
///   The location of the external content to be imported shall be specified by the relationship 
///   whose Id attribute matches the id attribute on this element. 
/// </summary>
public class AltChunk: ModelElement, IBodyContent, ITableCellContent, ICommentContent
{
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   External Content Import Properties.
  /// </summary>
  public AltChunkProperties? AltChunkProperties { get; set; }
}