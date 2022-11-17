namespace DocumentModel.Drawing;

public enum PresetMaterialType
{

  [XmlEnum("legacyMatte")]
  LegacyMatte,

  [XmlEnum("legacyPlastic")]
  LegacyPlastic,

  [XmlEnum("legacyMetal")]
  LegacyMetal,

  [XmlEnum("legacyWireframe")]
  LegacyWireframe,

  [XmlEnum("matte")]
  Matte,

  [XmlEnum("plastic")]
  Plastic,

  [XmlEnum("metal")]
  Metal,

  [XmlEnum("warmMatte")]
  WarmMatte,

  [XmlEnum("translucentPowder")]
  TranslucentPowder,

  [XmlEnum("powder")]
  Powder,

  [XmlEnum("dkEdge")]
  DarkEdge,

  [XmlEnum("softEdge")]
  SoftEdge,

  [XmlEnum("clear")]
  Clear,

  [XmlEnum("flat")]
  Flat,

  [XmlEnum("softmetal")]
  SoftMetal,
}
