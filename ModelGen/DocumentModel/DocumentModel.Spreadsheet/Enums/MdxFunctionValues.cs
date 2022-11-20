namespace DocumentModel.Spreadsheet;

/// <summary>
/// MDX Function Type
/// </summary>
public enum MdxFunctionValues
{
  /// <summary>
  /// Cube Member.
  /// </summary>
  [XmlEnum("m")]
  CubeMember,
  
  /// <summary>
  /// Cube Value.
  /// </summary>
  [XmlEnum("v")]
  CubeValue,
  
  /// <summary>
  /// Cube Set.
  /// </summary>
  [XmlEnum("s")]
  CubeSet,
  
  /// <summary>
  /// Cube Set Count.
  /// </summary>
  [XmlEnum("c")]
  CubeSetCount,
  
  /// <summary>
  /// Cube Ranked Member.
  /// </summary>
  [XmlEnum("r")]
  CubeRankedMember,
  
  /// <summary>
  /// Cube Member Property.
  /// </summary>
  [XmlEnum("p")]
  CubeMemberProperty,
  
  /// <summary>
  /// Cube KPI Member.
  /// </summary>
  [XmlEnum("k")]
  CubeKPIMember,
  
}
