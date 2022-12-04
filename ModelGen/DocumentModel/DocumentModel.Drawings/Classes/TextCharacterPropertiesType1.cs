namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public class TextCharacterPropertiesType1
{
  /// <summary>
  /// u
  /// </summary>
  public TextUnderlineKind? Underline
  {
    get;
    set;
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public TextStrikeKind? Strike
  {
    get;
    set;
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public TextCapsKind? Capital
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Outline? Outline
  {
    get;
    set;
  }
  
  public SolidFill? SolidFill
  {
    get;
    set;
  }
  
  public GradientFill? GradientFill
  {
    get;
    set;
  }
  
  public BlipFill1? BlipFill
  {
    get;
    set;
  }
  
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
  public EffectList? EffectList
  {
    get;
    set;
  }
  
  public EffectDag? EffectDag
  {
    get;
    set;
  }
  
  public Highlight? Highlight
  {
    get;
    set;
  }
  
  public UnderlineFill? UnderlineFill
  {
    get;
    set;
  }
  
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get;
    set;
  }
  
  public HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get;
    set;
  }
  
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
