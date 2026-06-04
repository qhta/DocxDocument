namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RubyAlignValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues))]
public enum RubyAlign
{
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues.Center))]
  Center,
  /// <summary>
  ///   Distribute All Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues.DistributeLetter))]
  DistributeLetter,
  /// <summary>
  ///   Distribute all Characters w/ Additional Space On Either Side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues.DistributeSpace))]
  DistributeSpace,
  /// <summary>
  ///   Left Aligned.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues.Left))]
  Left,
  /// <summary>
  ///   Right Aligned.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues.Right))]
  Right,
  /// <summary>
  ///   Vertically Aligned to Right of Base Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues.RightVertical))]
  RightVertical
}