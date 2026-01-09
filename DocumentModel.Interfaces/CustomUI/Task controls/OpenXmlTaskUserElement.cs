namespace DocumentModel;

/// <summary>
/// Represents a user element for task attribution in Office UI, supporting identification, naming, and provider information for advanced task management and collaboration scenarios.
/// </summary>
/// <remarks>
/// This interface defines a user element for Office UI task features, enabling unique identification, display naming, and provider association. It supports advanced workflows for task attribution, auditing, and integration in Office add-ins or document solutions.
/// </remarks>
public interface OpenXmlTaskUserElement
{
  /// <summary>
  /// Unique identifier for the user.
  /// </summary>
  public string? UserId { get; set; }

  /// <summary>
  /// Display name of the user.
  /// </summary>
  public string? UserName { get; set; }

  /// <summary>
  /// Provider or source of the user identity.
  /// </summary>
  public string? UserProvider { get; set; }
}