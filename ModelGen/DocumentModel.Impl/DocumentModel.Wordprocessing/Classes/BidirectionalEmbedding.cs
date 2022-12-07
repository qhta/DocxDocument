namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BidirectionalEmbedding Class.
/// </summary>
public class BidirectionalEmbeddingImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.BidirectionalEmbedding>, BidirectionalEmbedding
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
