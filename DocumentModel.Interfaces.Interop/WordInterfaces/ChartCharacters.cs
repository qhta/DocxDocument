namespace DocumentModel.Interop;

/// <summary>
/// Represents characters in an object that contains text.
/// </summary>
public partial interface ChartCharacters : InteropObject
{
  /// <summary>
  /// The caption.
  /// </summary>
  public string Caption { get; set; }

  /// <summary>
  /// The count.
  /// </summary>
  public int Count { get; }

  /// <summary>
  /// The font.
  /// </summary>
  public ChartFont Font { get; }

  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The phonetic characters.
  /// </summary>
  public string PhoneticCharacters { get; set; }
}
