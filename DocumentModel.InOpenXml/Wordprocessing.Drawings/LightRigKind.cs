namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
/// Specifies the type of light rig used for 3D rendering and shading effects in WordprocessingML drawings.
/// This enumeration provides values for various lighting configurations, supporting advanced visual effects and realistic lighting for graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LightRigKind
{
  
  /// <summary>
  /// Legacy flat light rig 1.
  /// </summary>
  LegacyFlat1,
  
  /// <summary>
  /// Legacy flat light rig 2.
  /// </summary>
  LegacyFlat2,
  
  /// <summary>
  /// Legacy flat light rig 3.
  /// </summary>
  LegacyFlat3,
  
  /// <summary>
  /// Legacy flat light rig 4.
  /// </summary>
  LegacyFlat4,
  
  /// <summary>
  /// Legacy normal light rig 1.
  /// </summary>
  LegacyNormal1,
  
  /// <summary>
  /// Legacy normal light rig 2.
  /// </summary>
  LegacyNormal2,
  
  /// <summary>
  /// Legacy normal light rig 3.
  /// </summary>
  LegacyNormal3,
  
  /// <summary>
  /// Legacy normal light rig 4.
  /// </summary>
  LegacyNormal4,
  
  /// <summary>
  /// Legacy harsh light rig 1.
  /// </summary>
  LegacyHarsh1,
  
  /// <summary>
  /// Legacy harsh light rig 2.
  /// </summary>
  LegacyHarsh2,
  
  /// <summary>
  /// Legacy harsh light rig 3.
  /// </summary>
  LegacyHarsh3,
  
  /// <summary>
  /// Legacy harsh light rig 4.
  /// </summary>
  LegacyHarsh4,
  
  /// <summary>
  /// Three-point light rig.
  /// </summary>
  ThreePoint,
  
  /// <summary>
  /// Balanced light rig.
  /// </summary>
  Balanced,
  
  /// <summary>
  /// Soft light rig.
  /// </summary>
  Soft,
  
  /// <summary>
  /// Harsh light rig.
  /// </summary>
  Harsh,
  
  /// <summary>
  /// Flood light rig.
  /// </summary>
  Flood,
  
  /// <summary>
  /// Contrasting light rig.
  /// </summary>
  Contrasting,
  
  /// <summary>
  /// Morning light rig.
  /// </summary>
  Morning,
  
  /// <summary>
  /// Sunrise light rig.
  /// </summary>
  Sunrise,
  
  /// <summary>
  /// Sunset light rig.
  /// </summary>
  Sunset,
  
  /// <summary>
  /// Chilly light rig.
  /// </summary>
  Chilly,
  
  /// <summary>
  /// Freezing light rig.
  /// </summary>
  Freezing,
  
  /// <summary>
  /// Flat light rig.
  /// </summary>
  Flat,
  
  /// <summary>
  /// Two-point light rig.
  /// </summary>
  TwoPoint,
  
  /// <summary>
  /// Glow light rig.
  /// </summary>
  Glow,
  
  /// <summary>
  /// Bright room light rig.
  /// </summary>
  BrightRoom
}