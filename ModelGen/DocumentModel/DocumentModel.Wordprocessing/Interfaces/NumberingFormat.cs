namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public interface NumberingFormat // : System.Boolean
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public NumberFormatKind? Val { get ; set; }
  
  /// <summary>
  /// format, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Format { get ; set; }
  
}
