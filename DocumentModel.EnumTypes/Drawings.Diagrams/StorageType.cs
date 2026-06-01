namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the STorageType enumeration.
/// Used Iin types such as NumberDiagramInfo, STorageType, NumberDiagramInfoConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StorageType
{
  /// <summary>
  ///   sibTrans.
  /// </summary>
  [OpenXmlEnumValue("SibTrans")]
  SibTrans,
  /// <summary>
  ///   parTrans.
  /// </summary>
  [OpenXmlEnumValue("ParTrans")]
  ParTrans
}

