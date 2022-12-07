namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public interface Font
{
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public FontCharSet? FontCharSet { get ; set; }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public FontFamilyKind? FontFamily { get ; set; }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public FontPitchKind? Pitch { get ; set; }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public FontSignature? FontSignature { get ; set; }
  
}
