namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RegionLabelLayoutEnum enumeration.
/// Used Iin types such as SeriesLayoutProperties, RegionLabelLayoutEnum, SeriesLayoutPropertiesConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RegionLabelLayoutEnum
{
  /// <summary>
  ///   none.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   bestFitOnly.
  /// </summary>
  [OpenXmlEnumValue("BestFitOnly")]
  BestFitOnly,
  /// <summary>
  ///   showAll.
  /// </summary>
  [OpenXmlEnumValue("ShowAll")]
  ShowAll
}

