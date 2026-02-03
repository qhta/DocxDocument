namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableWidthUnitValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlType(typeof(DXW.TableWidthUnitValues))]
public enum TableWidthUnit
{
  /// <summary>
  ///   No Width.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableWidthUnitValues.Nil))]
  Nil,
  /// <summary>
  ///   Width in Fiftieths of a Percent.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableWidthUnitValues.Pct))]
  Pct,
  /// <summary>
  ///   Width in Twentieths of a Point.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableWidthUnitValues.Dxa))]
  Twips,
  /// <summary>
  ///   Automatically Determined Width.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.TableWidthUnitValues.Auto))]
  Auto
}