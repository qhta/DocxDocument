namespace DocumentModel.Drawings;

/// <summary>
/// Alpha Modulate Effect.
/// </summary>
public class AlphaModulationEffectImpl: ModelElementImpl, AlphaModulationEffect
{
  public DocumentFormat.OpenXml.Drawing.AlphaModulationEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaModulationEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AlphaModulationEffectImpl(): base() {}
  
  public AlphaModulationEffectImpl(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public DocumentModel.Drawings.EffectContainer? EffectContainer
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
