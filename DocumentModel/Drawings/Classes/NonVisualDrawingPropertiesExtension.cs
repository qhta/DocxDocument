using DocumentModel.Drawings.Office.ScriptLink;

namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public class NonVisualDrawingPropertiesExtension: ModelElement
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