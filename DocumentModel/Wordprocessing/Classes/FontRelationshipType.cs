namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FontRelationshipType Class.
/// </summary>
public class FontRelationshipType: ModelElement
{
  /// <summary>
  ///   fontKey
  /// </summary>
  public String? FontKey { get; set; }

  /// <summary>
  ///   subsetted
  /// </summary>
  public Boolean? Subsetted { get; set; }

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  public String? Id { get; set; }
}