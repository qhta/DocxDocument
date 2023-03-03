namespace DocumentModel.Drawings.Diagrams;

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