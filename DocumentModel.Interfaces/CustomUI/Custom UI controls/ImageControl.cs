namespace DocumentModel;

/// <summary>
/// Represents an image control for Office UI, supporting flexible integration, dynamic state, and advanced callback options for displaying icons, logos, or decorative images in Backstage and layout containers.
/// </summary>
/// <remarks>
/// This interface defines an image control for Office UI, enabling unique identification, tagging, dynamic enable/visible state, image customization, and flexible placement in group boxes or layout containers. It supports advanced workflows for branding, information display, and extensibility in Office add-ins or document solutions.
/// </remarks>
public interface ImageControl : QualifiedElement, TaggedObject, EnableControl, VisibleControl, ImagedControl, GroupBoxContent, LayoutContent
{
  /// <summary>
  /// Alternative text for the image, supporting accessibility and descriptive labeling.
  /// </summary>
  public string? AltText { get; set; }

  /// <summary>
  /// Callback for dynamic alternative text.
  /// </summary>
  public string? GetAltText { get; set; }
}