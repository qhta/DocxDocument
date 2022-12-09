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
