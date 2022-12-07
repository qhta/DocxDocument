namespace DocumentModel.Drawings;

/// <summary>
/// Text Run Properties.
/// </summary>
public class RunPropertiesImpl: DocumentModel.Drawings.TextCharacterPropertiesType2Impl, RunProperties
{
  public override Outline? Outline
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
  
  public new Underline? Underline
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
