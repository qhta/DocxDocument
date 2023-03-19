namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupProperties Class.
/// </summary>
public class NonVisualGroupProperties: ModelElement
{
  /// <summary>
  ///   isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsLegacyGroup { get; set; }
}