namespace DocumentModel.CustomUI;

/// <summary>
/// Represents the Office Backstage view, supporting event handling and access to tab and fast command button controls for advanced customization scenarios.
/// </summary>
/// <remarks>
/// This interface defines the Backstage view with properties for event callbacks and access to tab and fast command button controls. It enables custom logic for showing and hiding the Backstage, and supports flexible arrangement of Backstage elements in Office applications.
/// </remarks>
public interface Backstage
{
  /// <summary>
  /// Callback executed when the Backstage view is shown.
  /// </summary>
  public string? OnShow { get; set; }

  /// <summary>
  /// Callback executed when the Backstage view is hidden.
  /// </summary>
  public string? OnHide { get; set; }

  /// <summary>
  /// Tab control displayed in the Backstage view.
  /// </summary>
  public BackstageTab? BackstageTab { get; set; }

  /// <summary>
  /// Fast command button control displayed in the Backstage view.
  /// </summary>
  public BackstageFastCommandButton? BackstageFastCommandButton { get; set; }
}