namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PresetMaterialTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetMaterialKind
{
  /// <summary>
  ///   legacyMatte.
  /// </summary>
  LegacyMatte,

  /// <summary>
  ///   legacyPlastic.
  /// </summary>
  LegacyPlastic,

  /// <summary>
  ///   legacyMetal.
  /// </summary>
  LegacyMetal,

  /// <summary>
  ///   legacyWireframe.
  /// </summary>
  LegacyWireframe,

  /// <summary>
  ///   matte.
  /// </summary>
  Matte,

  /// <summary>
  ///   plastic.
  /// </summary>
  Plastic,

  /// <summary>
  ///   metal.
  /// </summary>
  Metal,

  /// <summary>
  ///   warmMatte.
  /// </summary>
  WarmMatte,

  /// <summary>
  ///   translucentPowder.
  /// </summary>
  TranslucentPowder,

  /// <summary>
  ///   powder.
  /// </summary>
  Powder,

  /// <summary>
  ///   dkEdge.
  /// </summary>
  DarkEdge,

  /// <summary>
  ///   softEdge.
  /// </summary>
  SoftEdge,

  /// <summary>
  ///   clear.
  /// </summary>
  Clear,

  /// <summary>
  ///   flat.
  /// </summary>
  Flat,

  /// <summary>
  ///   softmetal.
  /// </summary>
  SoftMetal,

  /// <summary>
  ///   none.
  /// </summary>
  None
}