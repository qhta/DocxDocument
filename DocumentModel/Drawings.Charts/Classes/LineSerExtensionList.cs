namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineSerExtensionList Class.
/// </summary>
public class LineSerExtensionList: ModelElement
{
  public Collection<LineSerExtension>? LineSerExtensions { get; set; }
}