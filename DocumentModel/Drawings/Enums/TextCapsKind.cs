namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Cap Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TextCapsKind
{
  /// <summary>
  ///   Text Caps Enum ( None ).
  /// </summary>
  None,

  /// <summary>
  ///   Text Caps Enum ( Small ).
  /// </summary>
  Small,

  /// <summary>
  ///   Text Caps Enum ( All ).
  /// </summary>
  All
}