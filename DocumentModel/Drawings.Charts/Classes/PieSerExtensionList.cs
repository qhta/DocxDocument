namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PieSerExtensionList Class.
/// </summary>
public class PieSerExtensionList: ModelElement
{
  public Collection<PieSerExtension>? PieSerExtensions { get; set; }
}