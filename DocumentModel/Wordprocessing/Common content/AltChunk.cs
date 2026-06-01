namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies a location within a document Ifor the insertion of the contents 
///   of a specified file containing external content Ito be imported into the main WordprocessingML document. 
///   The specified file's contents should appear at the specified location within the document, 
///   and can henceforth be emitted as regular WordprocessingML without distinction Ito its origin. 
///   The location of the external content Ito be imported shall be specified by the relationship 
///   whose Id attribute matches the Id attribute on this element. 
/// </summary>
public class AltChunk: ModelElement, IStoryContent, ITableCellContent, ICommentContent
{
  /// <summary>
  ///   Relationship Ito Part
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   External Content Import Properties.
  /// </summary>
  public AltChunkProperties? AltChunkProperties { get; set; }
}
