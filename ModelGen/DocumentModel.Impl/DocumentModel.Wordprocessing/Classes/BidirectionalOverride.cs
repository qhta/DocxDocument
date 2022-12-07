namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BidirectionalOverride Class.
/// </summary>
public class BidirectionalOverrideImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalOverride>, BidirectionalOverride
{
  /// <summary>
  /// val
  /// </summary>
  public DirectionKind? Val
  {
    get => (DirectionKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.DirectionValues?)value;
    }
  }
  
}
