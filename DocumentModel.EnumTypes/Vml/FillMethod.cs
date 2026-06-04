namespace DocumentModel.Vml;
/// <summary>
///   Gradient Fill Computation Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.FillMethodValues))]
public enum FillMethod
{
  /// <summary>
  ///   No Gradient Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillMethodValues.None))]
  None,
  /// <summary>
  ///   Linear Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillMethodValues.Linear))]
  Linear,
  /// <summary>
  ///   Sigma Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillMethodValues.Sigma))]
  Sigma,
  /// <summary>
  ///   Application Default Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillMethodValues.Any))]
  Any,
  /// <summary>
  ///   Linear Sigma Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillMethodValues.Linearsigma))]
  LinearSigma
}