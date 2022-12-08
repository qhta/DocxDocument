namespace DocumentModel.Drawings;

/// <summary>
/// Alpha Inset/Outset Effect.
/// </summary>
public class AlphaOutsetImpl: ModelElementImpl, AlphaOutset
{
  public DocumentFormat.OpenXml.Drawing.AlphaOutset? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaOutset?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius
  {
    get;
    set;
  }
  
}
