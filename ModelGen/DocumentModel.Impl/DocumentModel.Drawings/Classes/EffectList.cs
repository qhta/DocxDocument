namespace DocumentModel.Drawings;

/// <summary>
/// Effect Container.
/// </summary>
public class EffectListImpl: ModelElementImpl, EffectList
{
  public DocumentFormat.OpenXml.Drawing.EffectList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.EffectList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public EffectListImpl(): base() {}
  
  public EffectListImpl(DocumentFormat.OpenXml.Drawing.EffectList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blur Effect.
  /// </summary>
  public DocumentModel.Drawings.Blur? Blur
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FillOverlay.
  /// </summary>
  public DocumentModel.Drawings.FillOverlay? FillOverlay
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Glow.
  /// </summary>
  public DocumentModel.Drawings.Glow? Glow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// InnerShadow.
  /// </summary>
  public DocumentModel.Drawings.InnerShadow? InnerShadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// OuterShadow.
  /// </summary>
  public DocumentModel.Drawings.OuterShadow? OuterShadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PresetShadow.
  /// </summary>
  public DocumentModel.Drawings.PresetShadow? PresetShadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Reflection.
  /// </summary>
  public DocumentModel.Drawings.Reflection? Reflection
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// SoftEdge.
  /// </summary>
  public DocumentModel.Drawings.SoftEdge? SoftEdge
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
