namespace DocumentModel;

/// <summary>
/// Defines properties for providing static or dynamic helper text associated with a group control.
/// </summary>
public interface HelperControl
{
  /// <summary>
  /// Helper text providing additional information about the group.
  /// </summary>
  public string? HelperText { get; set; }

  /// <summary>
  /// Callback for dynamic helper text.
  /// </summary>
  /// <remarks>
  ///   The callback function should return text that should be displayed as helper text.
  /// </remarks>

  public string? GetHelperText { get; set; }
}