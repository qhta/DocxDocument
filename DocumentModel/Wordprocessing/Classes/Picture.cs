using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   VML Object.
/// </summary>
public record Picture: RunElement
{
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? AnchorId { get; set; }

  public DocumentModel.Vml.Group? Group { get; set; }

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

  public RelationshipType? MovieReference { get; set; }

  public Control? Control { get; set; }
}