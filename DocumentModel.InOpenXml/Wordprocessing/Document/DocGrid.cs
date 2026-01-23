namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the document grid settings for a section in a WordprocessingML document.
/// This class extends <see cref="SectionPropertiesContent"/> and provides properties for grid type, line pitch, and character pitch, enabling advanced control over text layout, alignment, and grid-based formatting in East Asian and other grid-based document scenarios.
/// </summary>
public class DocGrid : ModelElement<DXW.DocGrid>, ISectionPropertiesContent
{

  /// <summary>
  /// Document grid type, specifying the kind of grid used for text layout (e.g., none, lines, lines and characters, snap to characters).
  /// </summary>
  public DocGridKind? Type { get; set; }

  /// <summary>
  /// Line pitch for the document grid, specifying the vertical spacing between grid lines in twips.
  /// </summary>
  public Twips? LinePitch { get; set; }

  /// <summary>
  /// Character pitch for the document grid, specifying the horizontal spacing between grid characters in twips.
  /// </summary>
  public Twips? CharacterSpace { get; set; }
}