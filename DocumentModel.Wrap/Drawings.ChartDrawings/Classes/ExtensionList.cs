namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ExtensionList Class.
/// </summary>
public class ExtensionList: ModelElement
{
  public Collection<Extension2>? Extension2s { get; set; }
}