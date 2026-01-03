namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CompatExtension interface.
/// </summary>
public interface CompatExtension: IModelElement
{
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ShapeId { get; set; }
}