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
