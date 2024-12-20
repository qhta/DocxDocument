namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Preset Material Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetMaterialKind
{
  /// <summary>
  ///   Legacy Matte.
  /// </summary>
  LegacyMatte,

  /// <summary>
  ///   Legacy Plastic.
  /// </summary>
  LegacyPlastic,

  /// <summary>
  ///   Legacy Metal.
  /// </summary>
  LegacyMetal,

  /// <summary>
  ///   Legacy Wireframe.
  /// </summary>
  LegacyWireframe,

  /// <summary>
  ///   Matte.
  /// </summary>
  Matte,

  /// <summary>
  ///   Plastic.
  /// </summary>
  Plastic,

  /// <summary>
  ///   Metal.
  /// </summary>
  Metal,

  /// <summary>
  ///   Warm Matte.
  /// </summary>
  WarmMatte,

  /// <summary>
  ///   Translucent Powder.
  /// </summary>
  TranslucentPowder,

  /// <summary>
  ///   Powder.
  /// </summary>
  Powder,

  /// <summary>
  ///   Dark Edge.
  /// </summary>
  DarkEdge,

  /// <summary>
  ///   Soft Edge.
  /// </summary>
  SoftEdge,

  /// <summary>
  ///   Clear.
  /// </summary>
  Clear,

  /// <summary>
  ///   Flat.
  /// </summary>
  Flat,

  /// <summary>
  ///   Soft Metal.
  /// </summary>
  SoftMetal
}