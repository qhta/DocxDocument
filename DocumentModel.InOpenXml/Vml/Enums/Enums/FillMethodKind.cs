namespace DocumentModel.Vml;
/// <summary>
///   Gradient Fill Computation Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.FillMethodValues))]
public enum FillMethodKind
{
  /// <summary>
  ///   No Gradient Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillMethodValues.None))]
  None,
  /// <summary>
  ///   Linear Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillMethodValues.Linear))]
  Linear,
  /// <summary>
  ///   Sigma Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillMethodValues.Sigma))]
  Sigma,
  /// <summary>
  ///   Application Default Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillMethodValues.Any))]
  Any,
  /// <summary>
  ///   Linear Sigma Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillMethodValues.Linearsigma))]
  Linearsigma
}