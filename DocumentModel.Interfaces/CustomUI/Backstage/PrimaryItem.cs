namespace DocumentModel.CustomUI;

/// <summary>
/// Represents the primary item for a backstage group in Office UI, supporting integration of regular buttons and primary menus for advanced customization scenarios.
/// </summary>
/// <remarks>
/// This interface defines the primary item for a backstage group, enabling the inclusion of a regular button or a primary menu as the main actionable element. It supports flexible arrangement and advanced customization of backstage views in Office applications.
/// </remarks>
public interface PrimaryItem
{
  /// <summary>
  /// Regular button control used as the primary item in the backstage group.
  /// </summary>
  public BackstageRegularButton? BackstageRegularButton { get; set; }

  /// <summary>
  /// Primary menu control used as the primary item in the backstage group.
  /// </summary>
  public BackstagePrimaryMenu? BackstagePrimaryMenu { get; set; }
}