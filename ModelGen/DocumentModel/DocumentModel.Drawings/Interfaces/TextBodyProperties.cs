namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBodyProperties Class.
/// </summary>
public interface TextBodyProperties
{
  /// <summary>
  /// Text Vertical Overflow
  /// </summary>
  public TextVerticalOverflowKind? VerticalOverflow { get ; set; }
  
  /// <summary>
  /// Text Horizontal Overflow
  /// </summary>
  public TextHorizontalOverflowKind? HorizontalOverflow { get ; set; }
  
  /// <summary>
  /// Vertical Text
  /// </summary>
  public TextVerticalKind? Vertical { get ; set; }
  
  /// <summary>
  /// Text Wrapping Type
  /// </summary>
  public TextWrappingKind? Wrap { get ; set; }
  
  /// <summary>
  /// Anchor
  /// </summary>
  public TextAnchoringKind? Anchor { get ; set; }
  
  /// <summary>
  /// Preset Text Shape.
  /// </summary>
  public PresetTextWrap? PresetTextWrap { get ; set; }
  
  public NormalAutoFit? NormalAutoFit { get ; set; }
  
  public Scene3DType? Scene3DType { get ; set; }
  
  public Shape3DType? Shape3DType { get ; set; }
  
  public FlatText? FlatText { get ; set; }
  
  public ExtensionList1? ExtensionList { get ; set; }
  
}
