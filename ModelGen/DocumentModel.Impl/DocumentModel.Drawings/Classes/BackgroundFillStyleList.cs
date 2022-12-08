namespace DocumentModel.Drawings;

/// <summary>
/// Background Fill Style List.
/// </summary>
public class BackgroundFillStyleListImpl: ModelElementImpl, BackgroundFillStyleList
{
  public DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<Boolean>? NoFills
  {
    get;
    set;
  }
  
  public Collection<SolidFill>? SolidFills
  {
    get;
    set;
  }
  
  public Collection<GradientFill>? GradientFills
  {
    get;
    set;
  }
  
  public Collection<BlipFill2>? BlipFills
  {
    get;
    set;
  }
  
  public Collection<PatternFill>? PatternFills
  {
    get;
    set;
  }
  
  public Collection<Boolean>? GroupFills
  {
    get;
    set;
  }
  
}
