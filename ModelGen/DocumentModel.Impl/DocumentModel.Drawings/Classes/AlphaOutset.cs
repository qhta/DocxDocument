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
  
  public AlphaOutsetImpl(): base() {}
  
  public AlphaOutsetImpl(DocumentFormat.OpenXml.Drawing.AlphaOutset openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius
  {
    get => (System.Int64?)OpenXmlElement?.Radius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Radius = (System.Int64?)value;
    }
  }
  
}
