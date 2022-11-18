namespace DocumentModel.Drawing;

/// <summary>
/// Preset Material Type
/// </summary>
public enum PresetMaterialType
{
  /// <summary>
  /// Legacy Matte.
  /// </summary>
  [XmlEnum("legacyMatte")]
  LegacyMatte,
  
  /// <summary>
  /// Legacy Plastic.
  /// </summary>
  [XmlEnum("legacyPlastic")]
  LegacyPlastic,
  
  /// <summary>
  /// Legacy Metal.
  /// </summary>
  [XmlEnum("legacyMetal")]
  LegacyMetal,
  
  /// <summary>
  /// Legacy Wireframe.
  /// </summary>
  [XmlEnum("legacyWireframe")]
  LegacyWireframe,
  
  /// <summary>
  /// Matte.
  /// </summary>
  [XmlEnum("matte")]
  Matte,
  
  /// <summary>
  /// Plastic.
  /// </summary>
  [XmlEnum("plastic")]
  Plastic,
  
  /// <summary>
  /// Metal.
  /// </summary>
  [XmlEnum("metal")]
  Metal,
  
  /// <summary>
  /// Warm Matte.
  /// </summary>
  [XmlEnum("warmMatte")]
  WarmMatte,
  
  /// <summary>
  /// Translucent Powder.
  /// </summary>
  [XmlEnum("translucentPowder")]
  TranslucentPowder,
  
  /// <summary>
  /// Powder.
  /// </summary>
  [XmlEnum("powder")]
  Powder,
  
  /// <summary>
  /// Dark Edge.
  /// </summary>
  [XmlEnum("dkEdge")]
  DarkEdge,
  
  /// <summary>
  /// Soft Edge.
  /// </summary>
  [XmlEnum("softEdge")]
  SoftEdge,
  
  /// <summary>
  /// Clear.
  /// </summary>
  [XmlEnum("clear")]
  Clear,
  
  /// <summary>
  /// Flat.
  /// </summary>
  [XmlEnum("flat")]
  Flat,
  
  /// <summary>
  /// Soft Metal.
  /// </summary>
  [XmlEnum("softmetal")]
  SoftMetal,
  
}
