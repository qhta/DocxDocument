using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Inline-Level Structured Document Tag Content.
/// </summary>
public class SdtContentRun: ElementCollection<ISdtContentRunElement>, ISdtRunElement
{
  public Math.Run? Run { get; set; }

  public CustomXmlRun? CustomXmlRun { get; set; }

  public Collection<SimpleField>? SimpleFields { get; set; }

  public Hyperlink? Hyperlink { get; set; }

  public SdtRun? SdtRun { get; set; }

  public BidirectionalOverride? BidirectionalOverride { get; set; }

  public BidirectionalEmbedding? BidirectionalEmbedding { get; set; }

  public RelationshipType? SubDocumentReference { get; set; }
}