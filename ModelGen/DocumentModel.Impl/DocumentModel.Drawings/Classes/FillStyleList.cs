namespace DocumentModel.Drawings;

/// <summary>
/// Fill Style List.
/// </summary>
public class FillStyleListImpl: ModelElementImpl, FillStyleList
{
  public DocumentFormat.OpenXml.Drawing.FillStyleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.FillStyleList?)_OpenXmlElement;
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
