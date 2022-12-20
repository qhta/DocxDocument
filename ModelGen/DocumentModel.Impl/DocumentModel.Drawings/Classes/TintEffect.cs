namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public partial class TintEffectImpl: ModelElementImpl, TintEffect
{
  public DocumentFormat.OpenXml.Drawing.TintEffect? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TintEffect?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TintEffectImpl(): base() {}
  
  public TintEffectImpl(DocumentFormat.OpenXml.Drawing.TintEffect openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue
  {
    get => (System.Int32?)OpenXmlElement?.Hue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hue = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount
  {
    get => (System.Int32?)OpenXmlElement?.Amount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Amount = (System.Int32?)value;
    }
  }
  
}
