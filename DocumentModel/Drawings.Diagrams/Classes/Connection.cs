namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Connection.
/// </summary>
public class Connection: ModelElement
{
  /// <summary>
  ///   Model Identifier
  /// </summary>
  public string? ModelId { get; set; }

  /// <summary>
  ///   Point Type
  /// </summary>
  public ConnectionKind? Type { get; set; }

  /// <summary>
  ///   Source Identifier
  /// </summary>
  public string? SourceId { get; set; }

  /// <summary>
  ///   Destination Identifier
  /// </summary>
  public string? DestinationId { get; set; }

  /// <summary>
  ///   Source Position
  /// </summary>
  public UInt32? SourcePosition { get; set; }

  /// <summary>
  ///   Destination Position
  /// </summary>
  public UInt32? DestinationPosition { get; set; }

  /// <summary>
  ///   Parent Transition Identifier
  /// </summary>
  public string? ParentTransitionId { get; set; }

  /// <summary>
  ///   Sibling Transition Identifier
  /// </summary>
  public string? SiblingTransitionId { get; set; }

  /// <summary>
  ///   Presentation Identifier
  /// </summary>
  public string? PresentationId { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}