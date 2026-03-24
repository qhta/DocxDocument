namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number spacing setting for an OpenType font.
/// </summary>
public enum WdNumberSpacing
{
  /// <summary>
  /// Applies the default number spacing for the font. wdNumberSpacingProportional1 Applies proportional number
  /// spacing to the font.
  /// </summary>
  Default = 0,
  /// <summary>
  /// Specifies the number spacing setting for an OpenType font.
  /// </summary>
  Proportional = 1,
  /// <summary>
  /// Applies tabular number spacing to the font.
  /// </summary>
  Tabular = 2
}
