namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupProperties interface.
/// </summary>
public interface NonVisualGroupProperties: IModelElement
{
  /// <summary>
  ///   isLegacyGroup
  /// </summary>
  public bool? IsLegacyGroup { get; set; }
}