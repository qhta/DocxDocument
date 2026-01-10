namespace DocumentModel;

/// <summary>
/// Represents a hyperlink control for the Office Backstage view, supporting navigation to external resources or document locations, dynamic state, customizable appearance, and advanced callback integration for flexible UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a hyperlink control for use in Office Backstage views (File menu). It supports navigation to external web resources, other documents, or specific document locations, and appears as a clickable text element with optional icon. The control supports static and dynamic target URLs, comprehensive formatting options, tooltips, layout behavior, and state management. The <c>OnAction</c> callback can override default navigation for custom handling. All properties can be set statically or determined dynamically through callback functions for responsive UI.
/// </remarks>
public interface Hyperlink: QualifiedElement, TaggedObject,
  EnableControl, VisibleControl,
  LabelledControl,
  ImagedControl,
  KeytipControl, ScreentipControl, SupertipControl,
  ActionControl, TargetControl,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{

  /// <summary>
  /// Alignment behavior of the hyperlink label.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  /// Expansion behavior of the hyperlink control.
  /// </summary>
  public ExpandKind? Expand { get; set; }
}