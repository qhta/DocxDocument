namespace DocumentModel.Drawings;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
public class WholeImpl: ModelElementImpl, Whole
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Whole? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Whole?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Outline? Outline
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public EffectList? EffectList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public EffectDag? EffectDag
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
