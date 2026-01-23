namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Specifies the preset material type options for 3D rendering in WordprocessingML drawings.
/// This enumeration provides values for various material effects, supporting advanced visual appearance and surface rendering for 3D shapes and graphical elements within the document.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PresetMaterialKind
{
  /// <summary>
  /// Legacy matte material.
  /// </summary>
  LegacyMatte,
    
  /// <summary>
  /// Legacy plastic material.
  /// </summary>
  LegacyPlastic,
    
  /// <summary>
  /// Legacy metal material.
  /// </summary>
  LegacyMetal,
    
  /// <summary>
  /// Legacy wireframe material.
  /// </summary>
  LegacyWireframe,
    
  /// <summary>
  /// Matte material.
  /// </summary>
  Matte,
    
  /// <summary>
  /// Plastic material.
  /// </summary>
  Plastic,
    
  /// <summary>
  /// Metal material.
  /// </summary>
  Metal,
    
  /// <summary>
  /// Warm matte material.
  /// </summary>
  WarmMatte,
    
  /// <summary>
  /// Translucent powder material.
  /// </summary>
  TranslucentPowder,
    
  /// <summary>
  /// Powder material.
  /// </summary>
  Powder,
    
  /// <summary>
  /// Dark edge material.
  /// </summary>
  DarkEdge,
    
  /// <summary>
  /// Soft edge material.
  /// </summary>
  SoftEdge,
    
  /// <summary>
  /// Clear material.
  /// </summary>
  Clear,
    
  /// <summary>
  /// Flat material.
  /// </summary>
  Flat,
    
  /// <summary>
  /// Soft metal material.
  /// </summary>
  SoftMetal,
    
  /// <summary>
  /// No material effect.
  /// </summary>
  None
}