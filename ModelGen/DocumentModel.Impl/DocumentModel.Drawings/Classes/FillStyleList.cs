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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<SolidFill>? SolidFills
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<GradientFill>? GradientFills
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<BlipFill1>? BlipFills
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<PatternFill>? PatternFills
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Boolean>? GroupFills
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
