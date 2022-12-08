namespace DocumentModel.Drawings;

/// <summary>
/// Background Formatting.
/// </summary>
public class BackgroundImpl: ModelElementImpl, Background
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Background? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Background?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Boolean? NoFill
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
  
  public BlipFill2? BlipFill
  {
    get;
    set;
  }
  
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
  public Boolean? GroupFill
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
  
}
