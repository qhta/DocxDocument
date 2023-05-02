using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents an inline embedded object in text run. 
///   The layout properties of this embedded object, as well as an optional static representation, 
///   are specified using the drawing element.
/// </summary>
public class EmbeddedObject: ElementCollection<IEmbeddedObjectContent>, IRunContent
{
  /// <summary>
  ///   valOrig
  /// </summary>
  public string? DxaOriginal { get; set; }

  /// <summary>
  ///   dyaOrig
  /// </summary>
  public string? DyaOriginal { get; set; }

  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? AnchorId { get; set; }

  public DMV.Group? Group { get; set; }

  public ImageFile? ImageFile { get; set; }

  public Line? Line { get; set; }

  public Oval? Oval { get; set; }

  public PolyLine? PolyLine { get; set; }

  public Rectangle? Rectangle { get; set; }

  public RoundRectangle? RoundRectangle { get; set; }

  public Shape? Shape { get; set; }

  public Shapetype? Shapetype { get; set; }

  public Arc? Arc { get; set; }

  public Curve? Curve { get; set; }

  public OleObject? OleObject { get; set; }

  public Drawing? Drawing { get; set; }

  public Control? Control { get; set; }

  public ObjectEmbed? ObjectEmbed { get; set; }

  public ObjectLink? ObjectLink { get; set; }
}