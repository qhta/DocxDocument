namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base class for ParagraphMarkRunProperties classes.
///   Contains  these common properties, which are not applied to <see cref="RunPropertiesBase"/>
/// </summary>
public abstract class ParagraphMarkRunPropertiesBase: RunPropertiesBase
{
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  public TrackChangeType? Inserted { get; set; }

  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  public TrackChangeType? Deleted { get; set; }

  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  public TrackChangeType? MoveFrom { get; set; }

  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  public TrackChangeType? MoveTo { get; set; }

  /// <summary>
  /// Specifies that the parent object has been inserted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType2? ConflictInsertion { get; set; }

  /// <summary>
  /// /Specifies that the parent object has been deleted in conflict with edits made by other users.
  /// </summary>
  public TrackChangeType2? ConflictDeletion { get; set; }

  /// <summary>
  ///  Specifies that this run contains WordprocessingML which shall be handled as though it was Office Open XML Math.
  ///  Like other run properties can be applied to the glyph representing the paragraph mark, it is possible
  ///  to create an Office Open XML Math equation on an empty paragraph as well. Since that paragraph mark must be
  ///  defined by WordprocessingML, it is not possible to store the paragraph using the Office Open XML Math
  ///  markup. Instead, this run property is stored on the paragraph mark's run properties to indicate that the
  ///  paragraph mark is part of an Office Open XML Math equation.
  /// </summary>
  public Boolean? OfficeMath { get; set; }

}