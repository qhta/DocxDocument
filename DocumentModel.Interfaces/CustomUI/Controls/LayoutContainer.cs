namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a container for organizing and arranging controls in the Office Backstage view, supporting flexible layout, alignment, expansion, and integration of various child control types for advanced UI scenarios.
/// </summary>
/// <remarks>
/// This interface defines a layout container for the Backstage view, enabling structured, responsive interfaces with support for nested containers, alignment control, and a variety of child controls. It provides sophisticated layout capabilities for custom Backstage pages, document management workflows, settings panels, and information displays in Office applications.
/// </remarks>
public interface LayoutContainer : QualifiedElement, TaggedObject,
  LayoutContentCollection,
  GroupBoxContent, LayoutContent, BackstageGroupContent
{

  /// <summary>
  /// Layout direction for arranging child controls.
  /// </summary>
  public LayoutChildrenKind? LayoutChildren { get; set; }

}