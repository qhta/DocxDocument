namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the ViewValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXP.ViewValues))]
public enum ViewType
{
  /// <summary>
  ///   Default View.
  /// </summary>
  None,
  /// <summary>
  ///   Print Layout View.
  /// </summary>
  Print,
  /// <summary>
  ///   Outline View.
  /// </summary>
  Outline,
  /// <summary>
  ///   Master Document View.
  /// </summary>
  MasterPages,
  /// <summary>
  ///   Draft View.
  /// </summary>
  Normal,
  /// <summary>
  ///   Web Page View.
  /// </summary>
  Web
}