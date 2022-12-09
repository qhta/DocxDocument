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
  
  /// <summary>
  /// EffectContainer.
  /// </summary>
  public EffectContainer? EffectContainer
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
