namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the DataModelExtensionBlock Class.
/// </summary>
public interface DataModelExtensionBlock: IModelElement
{
  /// <summary>
  ///   relId
  /// </summary>
  public string? RelId { get; set; }
  /// <summary>
  ///   minVer
  /// </summary>
  public string? MinVer { get; set; }
}