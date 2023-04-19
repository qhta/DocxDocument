namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataModelExtensionBlock Class.
/// </summary>
public class DataModelExtensionBlock: ModelElement
{
  /// <summary>
  ///   relId, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelId { get; set; }

  /// <summary>
  ///   minVer, this property is only available in Office 2010 and later.
  /// </summary>
  public string? MinVer { get; set; }
}