namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Symbol Run Properties.
/// </summary>
public interface NumberingSymbolRunProperties
{
  /// <summary>
  /// RunFonts.
  /// </summary>
  public RunFonts? RunFonts { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public Color? Color { get ; set; }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public Underline? Underline { get ; set; }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
  public TextEffectKind? TextEffect { get ; set; }
  
  /// <summary>
  /// Border.
  /// </summary>
  public BorderType? Border { get ; set; }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading { get ; set; }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public FitText? FitText { get ; set; }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get ; set; }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
  public EmphasisMarkKind? Emphasis { get ; set; }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public EastAsianLayout? EastAsianLayout { get ; set; }
  
}
