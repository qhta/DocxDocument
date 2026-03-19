namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single text column.
/// </summary>
public interface TextColumn : InteropObject
{
  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }
  /// <summary>
  /// The space after.
  /// </summary>
  public float SpaceAfter { get; set; }

}
