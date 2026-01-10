namespace DocumentModel.CustomUI;

/// <summary>
/// Represents a control that navigates to a specified target URL or location when activated, supporting both static and dynamic target resolution for flexible Office UI scenarios.
/// </summary>
/// <remarks>
/// Implementations should ensure that only one of the <c>Target</c> or <c>GetTarget</c> properties is set at a time, as they are mutually exclusive. If neither property is set, no target navigation is performed for the control.
/// </remarks>
public interface TargetControl
{
  /// <summary>
  /// Target URL or location for navigation when the control is activated.
  /// </summary>
  public string? Target { get; set; }

  /// <summary>
  /// Callback for dynamic target URL or location resolution.
  /// </summary>
  public string? GetTarget { get; set; }
}