namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum StyleKind
{
  /// <summary>
  ///   Plain.
  /// </summary>
  Plain,

  /// <summary>
  ///   Bold.
  /// </summary>
  Bold,

  /// <summary>
  ///   Italic.
  /// </summary>
  Italic,

  /// <summary>
  ///   Bold-Italic.
  /// </summary>
  BoldItalic
}