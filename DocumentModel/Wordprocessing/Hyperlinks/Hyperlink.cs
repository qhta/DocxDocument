using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Hyperlink Class.
/// </summary>
public class Hyperlink: ElementCollection<IHyperlinkContent>, 
  IParagraphContent, 
  ISdtRunContent, 
  IBidirectionalContent, 
  DMM.IMathArgumentContent,
  IHyperlinkContent
{
  /// <summary>
  ///   Hyperlink Target Frame
  /// </summary>
  public string? TargetFrame { get; set; }

  /// <summary>
  ///   Associated String
  /// </summary>
  public string? Tooltip { get; set; }

  /// <summary>
  ///   Location in Target Document
  /// </summary>
  public string? DocLocation { get; set; }

  /// <summary>
  ///   Add To Viewed Hyperlinks
  /// </summary>
  public bool? History { get; set; }

  /// <summary>
  ///   Hyperlink Anchor
  /// </summary>
  public string? Anchor { get; set; }

  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  public string? Id { get; set; }

  public CustomXmlRun? CustomXmlRun { get; set; }

  public Collection<SimpleField>? SimpleFields { get; set; }

  public Hyperlink? ChildHyperlink { get; set; }

  public SdtRun? SdtRun { get; set; }

  public Math.Run? Run { get; set; }

  public BidirectionalOverride? BidirectionalOverride { get; set; }

  public BidirectionalEmbedding? BidirectionalEmbedding { get; set; }

  public SubDocumentReference? SubDocumentReference { get; set; }
}