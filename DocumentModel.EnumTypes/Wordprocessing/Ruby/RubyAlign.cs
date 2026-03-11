namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the RubyAlignValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.RubyAlignValues))]
public enum RubyAlign
{
  /// <summary>
  ///   Center.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RubyAlignValues.Center))]
  Center,
  /// <summary>
  ///   Distribute All Characters.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RubyAlignValues.DistributeLetter))]
  DistributeLetter,
  /// <summary>
  ///   Distribute all Characters w/ Additional Space On Either Side.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RubyAlignValues.DistributeSpace))]
  DistributeSpace,
  /// <summary>
  ///   Left Aligned.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RubyAlignValues.Left))]
  Left,
  /// <summary>
  ///   Right Aligned.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RubyAlignValues.Right))]
  Right,
  /// <summary>
  ///   Vertically Aligned to Right of Base Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.RubyAlignValues.RightVertical))]
  RightVertical
}