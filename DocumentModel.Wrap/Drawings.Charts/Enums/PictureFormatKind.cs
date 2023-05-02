namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Picture Format
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PictureFormatKind
{
  /// <summary>
  ///   Stretch.
  /// </summary>
  Stretch,

  /// <summary>
  ///   Stack.
  /// </summary>
  Stack,

  /// <summary>
  ///   Stack and Scale.
  /// </summary>
  StackScale
}