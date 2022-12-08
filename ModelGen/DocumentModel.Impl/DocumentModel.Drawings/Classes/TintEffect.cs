namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public class TintEffectImpl: ModelElementImpl, TintEffect
{
  public DocumentFormat.OpenXml.Drawing.TintEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TintEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue
  {
    get;
    set;
  }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount
  {
    get;
    set;
  }
  
}
