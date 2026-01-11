namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a border type definition in a WordprocessingML document.
/// This interface provides properties for border style, width, and shadow effect, enabling advanced formatting and visual separation of document content.
/// </summary>
public interface BorderType
{
  /// <summary>
  /// Border style, specifying the type of border (e.g., single, double, dashed).
  /// </summary>
  public BorderKind? Type { get; set; }

  /// <summary>
  /// Border width, specified as a 64-bit integer value.
  /// </summary>
  public Int64? Width { get; set; }

  /// <summary>
  /// Indicates whether the border has a shadow effect.
  /// </summary>
  public bool? Shadow { get; set; }
}