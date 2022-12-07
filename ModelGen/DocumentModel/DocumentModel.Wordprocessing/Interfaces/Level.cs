namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Definition.
/// </summary>
public interface Level
{
  /// <summary>
  /// Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Content Between Numbering Symbol and Paragraph Text.
  /// </summary>
  public LevelSuffixKind? LevelSuffix { get ; set; }
  
  /// <summary>
  /// Numbering Level Text.
  /// </summary>
  public LevelText? LevelText { get ; set; }
  
  /// <summary>
  /// Legacy Numbering Level Properties.
  /// </summary>
  public LegacyNumbering? LegacyNumbering { get ; set; }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public LevelJustificationKind? LevelJustification { get ; set; }
  
  /// <summary>
  /// Numbering Level Associated Paragraph Properties.
  /// </summary>
  public PreviousParagraphProperties? PreviousParagraphProperties { get ; set; }
  
  /// <summary>
  /// Numbering Symbol Run Properties.
  /// </summary>
  public NumberingSymbolRunProperties? NumberingSymbolRunProperties { get ; set; }
  
}
