namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the CompatExtension Class.
/// </summary>
public class CompatExtension: ModelElement
{
  /// <summary>
  ///   spid, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? ShapeId { get; set; }
}
