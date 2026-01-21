namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies a location within a document for the insertion of the contents of a specified file containing external content to be imported into the main WordprocessingML document.
/// The specified file's contents appear at the specified location and are treated as regular WordprocessingML content. The location of the external content is determined by the relationship whose Id attribute matches the Id attribute on this element.
/// </summary>
public partial class AltChunk : ModelElement<DXW.AltChunk>, IStoryContent, ITableCellContent, ICommentContent
{
  /// <summary>
  /// Relationship ID to the part containing the external content to be imported.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  /// Properties for external content import, specifying additional import options and settings.
  /// </summary>
  public AltChunkProperties? AltChunkProperties { get; set; }
}