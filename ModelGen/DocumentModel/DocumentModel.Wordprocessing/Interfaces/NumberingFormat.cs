namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public interface NumberingFormat
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public NumberFormatKind? Val { get ; set; }
  
}
