namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableStyleOverrideValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableStyleOverrideValues))]
public enum TableStyleOverride
{
  /// <summary>
  ///   Whole table formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.WholeTable))]
  WholeTable,
  /// <summary>
  ///   First Row Conditional Formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.FirstRow))]
  FirstRow,
  /// <summary>
  ///   Last table row formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.LastRow))]
  LastRow,
  /// <summary>
  ///   First IColumn Conditional Formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.FirstColumn))]
  FirstColumn,
  /// <summary>
  ///   Last table column formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.LastColumn))]
  LastColumn,
  /// <summary>
  ///   Banded IColumn Conditional Formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.Band1Vertical))]
  Band1Vertical,
  /// <summary>
  ///   Even IColumn Stripe Conditional Formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.Band2Vertical))]
  Band2Vertical,
  /// <summary>
  ///   Banded Row Conditional Formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.Band1Horizontal))]
  Band1Horizontal,
  /// <summary>
  ///   Even Row Stripe Conditional Formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.Band2Horizontal))]
  Band2Horizontal,
  /// <summary>
  ///   Top right table cell formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.NorthEastCell))]
  NorthEastCell,
  /// <summary>
  ///   Top left table cell formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.NorthWestCell))]
  NorthWestCell,
  /// <summary>
  ///   Bottom right table cell formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.SouthEastCell))]
  SouthEastCell,
  /// <summary>
  ///   Bottom left table cell formatting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableStyleOverrideValues.SouthWestCell))]
  SouthWestCell
}