namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableWidthUnitValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlType(typeof(DXW.TableWidthUnitValues))]
public enum TableMeasureType
{

  /// <summary>
  ///   Automatically Determined Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableWidthUnitValues.Auto))]
  Auto,

  /// <summary>
  ///   Width in Twentieths of a IPoint.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableWidthUnitValues.Dxa))]
  Absolute,

  /// <summary>
  ///   Width in Fiftieths of a Percent.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableWidthUnitValues.Pct))]
  Percent,

  /// <summary>
  ///   No Width.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableWidthUnitValues.Nil))]
  Nil,
}
