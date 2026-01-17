namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupProperties interface.
/// </summary>
public class NonVisualGroupProperties: ModelElement<DXO13D.NonVisualGroupProperties>
{
  /// <summary>
  ///   isLegacyGroup
  /// </summary>
  public bool? IsLegacyGroup { get; set; }
}