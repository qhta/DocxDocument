namespace DocumentModel.Drawings.Charts;

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