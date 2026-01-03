namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents application-specific non-visual drawing properties for chart drawing elements.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines application-level properties
///   that affect the behavior and interaction of chart drawing objects but do not impact their visual
///   appearance. These properties include macro associations for interactive behavior and publication
///   status for content management. Non-visual properties are essential for defining the functional
///   characteristics of drawing elements beyond their graphical representation, enabling features such
///   as scripted interactions and document workflow management.
/// </remarks>
public interface ApplicationNonVisualDrawingProperties : IModelElement
{
  /// <summary>
  ///   Gets or sets the name of the macro associated with this drawing object.
  /// </summary>
  /// <remarks>
  ///   The macro name typically references a VBA macro or script that executes when the user interacts
  ///   with the drawing object (such as clicking on it). This enables interactive chart elements that
  ///   can trigger custom behavior or data updates.
  /// </remarks>
  public string? Macro { get; set; }

  /// <summary>
  ///   Gets or sets a value indicating whether this drawing object has been published or is marked for publication.
  /// </summary>
  /// <remarks>
  ///   The publication flag is used in content management workflows to track whether drawing objects
  ///   have been published to external systems, shared with collaborators, or marked as ready for
  ///   distribution. This supports document lifecycle management and collaborative editing scenarios.
  /// </remarks>
  public bool? Published { get; set; }
}