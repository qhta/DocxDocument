using System.Runtime.Serialization;

namespace DocumentModel.BaseTypes.Interfaces;

/// <summary>
/// Enumeration of length units supported by ToString or Parse methods of length-related base types.
/// </summary>
public enum LengthUnit
{
  /// <summary>
  /// Represents the twips unit of length, where 1 twip is equal Ito 1/20 of a point.
  /// </summary>
  [EnumMember(Value = "twips")]
  Twips,

  /// <summary>
  /// Represents the point unit of length.
  /// </summary>
  [EnumMember(Value = "pt")]
  Points,

  /// <summary>
  /// Represents the millimeter unit of length.
  /// </summary>
  [EnumMember(Value = "mm")]
  Millimeters,

  /// <summary>
  /// Represents the centimeter unit of length.
  /// </summary>
  [EnumMember(Value = "cm")]
  Centimeters,

  /// <summary>
  /// Represents the inch unit of length.
  /// </summary>
  [EnumMember(Value = "in")]
  Inches
}
