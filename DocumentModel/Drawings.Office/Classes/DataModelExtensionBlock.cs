namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the DataModelExtensionBlock Class.
/// </summary>
public class DataModelExtensionBlock: ModelElement
{
  /// <summary>
  ///   relId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelId { get; set; }

  /// <summary>
  ///   minVer, this property is only available in Office 2010 and later.
  /// </summary>
  public String? MinVer { get; set; }
}