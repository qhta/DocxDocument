namespace DocumentModel.Vml;

/// <summary>
///   Screen Sizes Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ScreenSizeKind
{
  /// <summary>
  ///   544x376 pixels.
  /// </summary>
  Sz544x376,

  /// <summary>
  ///   640x480 pixels.
  /// </summary>
  Sz640x480,

  /// <summary>
  ///   720x512 pixels.
  /// </summary>
  Sz720x512,

  /// <summary>
  ///   800x600 pixels.
  /// </summary>
  Sz800x600,

  /// <summary>
  ///   1024x768 pixels.
  /// </summary>
  Sz1024x768,

  /// <summary>
  ///   1152x862 pixels.
  /// </summary>
  Sz1152x862
}