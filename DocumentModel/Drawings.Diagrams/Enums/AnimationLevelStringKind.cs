namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Animation Level String Definition
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AnimationLevelStringKind
{
  /// <summary>
  ///   Disable Level At Once.
  /// </summary>
  None,

  /// <summary>
  ///   By Level Animation.
  /// </summary>
  Level,

  /// <summary>
  ///   From Center Animation.
  /// </summary>
  Center
}