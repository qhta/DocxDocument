namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a collection of controls for display within a backstage group, supporting a comprehensive set of UI elements for Office customization.
/// </summary>
public interface BackstageGroupContentCollection: ElementCollection<BackstageGroupContent>
{
  /// <summary>
  /// Backstage group button control.
  /// </summary>
  public BackstageGroupButton? BackstageGroupButton { get; set; }

}