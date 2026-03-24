namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableLayoutValues))]
public enum TableLayoutType
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Fixed Width Table Layout.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableLayoutValues.Fixed))]
  Fixed = 1,

  /// <summary>
  ///   AutoFit Table Layout.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableLayoutValues.Autofit))]
  Autofit
}