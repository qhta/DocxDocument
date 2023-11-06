namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TableLayoutValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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