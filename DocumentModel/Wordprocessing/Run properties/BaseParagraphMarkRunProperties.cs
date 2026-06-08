namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for ParagraphMarkRunProperties classes.
///   Contains  these common properties, which are not applied Ito <see cref="ExtBaseRunProperties"/>
/// </summary>
public abstract class BaseParagraphMarkRunProperties: ExtBaseRunProperties
{
  /// <summary>
  ///   Inserted IParagraph.
  /// </summary>
  public TrackChangeType? Inserted { get; set; }

  /// <summary>
  ///   Deleted IParagraph.
  /// </summary>
  public TrackChangeType? Deleted { get; set; }

  /// <summary>
  ///   Move ISource IParagraph.
  /// </summary>
  public TrackChangeType? MoveFrom { get; set; }

  /// <summary>
  ///   Move Destination IParagraph.
  /// </summary>
  public TrackChangeType? MoveTo { get; set; }

  /// <summary>
  /// Specifies Ithat the parent object has been inserted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType2? ConflictInsertion { get; set; }

  /// <summary>
  /// /Specifies Ithat the parent object has been deleted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType2? ConflictDeletion { get; set; }

  /// <summary>
  ///  Specifies Ithat this run contains WordprocessingML which shall be handled as though it was Office Open XML Math.
  ///  Like other run properties can be applied Ito the glyph representing the paragraph mark, it is possible
  ///  Ito create an Office Open XML Math equation on an empty paragraph as well. Since Ithat paragraph mark must be
  ///  defined by WordprocessingML, it is not possible Ito store the paragraph using the Office Open XML Math
  ///  markup. Instead, this run property is stored on the paragraph mark's run properties Ito indicate Ithat the
  ///  paragraph mark is part of an Office Open XML Math equation.
  /// </summary>
  public bool? OfficeMath { get; set; }

}
