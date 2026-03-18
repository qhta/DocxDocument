namespace DocumentModel.Drawings.Diagram1;

/// <summary>
/// Defines the STorageType enumeration.
/// Used in types such as NumberDiagramInfo, STorageType, NumberDiagramInfoConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum STorageType
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
