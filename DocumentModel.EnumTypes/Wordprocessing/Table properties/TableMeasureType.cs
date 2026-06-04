namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableWidthUnitValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlType(typeof(DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues))]
public enum TableMeasureType
{

  /// <summary>
  ///   No Width.
  /// </summary>
  [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues.Nil))]
  Nil,

  /// <summary>
  ///   Automatically Determined Width.
  /// </summary>
  [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues.Auto))]
  Auto,

  /// <summary>
  ///   Width in Fiftieths of a Percent.
  /// </summary>
  [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues.Pct))]
  Relative,

  /// <summary>
  ///   Width in Twentieths of a Point.
  /// </summary>
  [OpenXmlProperty(nameof(DocumentFormat.OpenXml.Wordprocessing.TableWidthUnitValues.Dxa))]
  Absolute,


}