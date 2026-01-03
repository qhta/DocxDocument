namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualGroupProperties interface.
/// </summary>
public interface NonVisualGroupProperties: IModelElement
{
  /// <summary>
  ///   isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsLegacyGroup { get; set; }
}