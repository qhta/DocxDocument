namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CompatExtension Class.
/// </summary>
public class CompatExtension: ModelElement
{
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ShapeId { get; set; }
}