namespace DocumentModel.Drawings;

/// <summary>
/// Effect.
/// </summary>
public class EffectImpl: ModelElementImpl, Effect
{
  public DocumentFormat.OpenXml.Drawing.Effect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Effect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference
  {
    get;
    set;
  }
  
}
