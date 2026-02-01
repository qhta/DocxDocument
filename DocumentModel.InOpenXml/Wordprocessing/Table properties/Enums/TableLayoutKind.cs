namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableLayoutValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableLayoutValues))]
public enum TableLayoutKind
{
  /// <summary>
  ///   Fixed Width Table Layout.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableLayoutValues.Fixed))]
  Fixed,
  /// <summary>
  ///   AutoFit Table Layout.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableLayoutValues.Autofit))]
  Autofit
}