namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ObjectLink Class.
/// </summary>
public class ObjectLink: ModelElement, IEmbeddedObjectElement
{
  /// <summary>
  ///   updateMode
  /// </summary>
  public ObjectUpdateMode? UpdateMode { get; set; }

  /// <summary>
  ///   lockedField
  /// </summary>
  public Boolean? LockedField { get; set; }

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