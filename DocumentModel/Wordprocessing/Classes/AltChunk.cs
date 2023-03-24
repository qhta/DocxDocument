namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the AltChunk Class.
/// </summary>
public class AltChunk: ModelElement, IBodyElement, ITableCellElement
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