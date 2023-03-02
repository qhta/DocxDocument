using DocumentModel.Drawings.Office.ScriptLink;

namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public record NonVisualDrawingPropertiesExtension
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public CompatExtension? CompatExtension { get; set; }

  public BackgroundProperties? BackgroundProperties { get; set; }

  public CreationId? CreationId { get; set; }

  public PredecessorDrawingElementReference? PredecessorDrawingElementReference { get; set; }

  public Boolean? Decorative { get; set; }

  public ClassificationOutcome? ClassificationOutcome { get; set; }

  public ScriptLink? ScriptLink { get; set; }
}