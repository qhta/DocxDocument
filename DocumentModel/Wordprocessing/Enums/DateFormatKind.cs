namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DateFormatValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DateFormatKind
{
  /// <summary>
  ///   Same As Display.
  /// </summary>
  Text,

  /// <summary>
  ///   XML Schema Date Format.
  /// </summary>
  Date,

  /// <summary>
  ///   XML Schema DateTime Format.
  /// </summary>
  DateTime
}