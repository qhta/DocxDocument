namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ErrorBarDirection enumeration.
/// Used in types such as ErrorBar.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.ErrorBarDirectionValues))]
public enum ErrorBarDirection
{
  /// <summary>
  ///   X.
  /// </summary>
  [OpenXmlEnumValue("X")]
  X,
  /// <summary>
  ///   Y.
  /// </summary>
  [OpenXmlEnumValue("Y")]
  Y
}
