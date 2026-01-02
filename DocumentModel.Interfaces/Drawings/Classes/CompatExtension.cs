namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CompatExtension Class.
/// </summary>
public class CompatExtension: ModelElement
{
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ShapeId { get; set; }
}