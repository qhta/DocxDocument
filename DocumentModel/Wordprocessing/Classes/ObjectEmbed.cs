namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ObjectEmbed Class.
/// </summary>
public record ObjectEmbed: EmbeddedObjectElement
{
  /// <summary>
  ///   drawAspect
  /// </summary>
  public ObjectDrawAspect? drawAspect { get; set; }

  /// <summary>
  ///   id
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   progId
  /// </summary>
  public String? ProgId { get; set; }

  /// <summary>
  ///   shapeId
  /// </summary>
  public String? ShapeId { get; set; }

  /// <summary>
  ///   fieldCodes
  /// </summary>
  public String? FieldCodes { get; set; }
}