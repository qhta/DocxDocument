using DocumentModel.Drawings.Office.ScriptLink;
namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extension for non-visual drawing properties, providing additional metadata and configuration options.
/// </summary>
public interface NonVisualDrawingPropertiesExtension
{
  /// <summary>
  ///   Uniform Resource Identifier for the extension.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  ///   Compatibility extension for handling legacy or platform-specific features.
  /// </summary>
  public CompatExtension? CompatExtension { get; set; }

  /// <summary>
  ///   Background properties for the drawing element.
  /// </summary>
  public BackgroundProperties? BackgroundProperties { get; set; }

  /// <summary>
  ///   Unique creation identifier for the drawing element.
  /// </summary>
  public CreationId? CreationId { get; set; }

  /// <summary>
  ///   Reference to a predecessor drawing element.
  /// </summary>
  public PredecessorDrawingElementReference? PredecessorDrawingElementReference { get; set; }

  /// <summary>
  ///   Indicates whether the element is decorative.
  /// </summary>
  public bool? Decorative { get; set; }

  /// <summary>
  ///   Classification outcome for accessibility or categorization.
  /// </summary>
  public ClassificationOutcome? ClassificationOutcome { get; set; }

  /// <summary>
  ///   Script link associated with the drawing element.
  /// </summary>
  public ScriptLink? ScriptLink { get; set; }
}