namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TableLayoutKind
{
  /// <summary>
  ///   Fixed Width Table Layout.
  /// </summary>
  Fixed,

  /// <summary>
  ///   AutoFit Table Layout.
  /// </summary>
  Autofit
}