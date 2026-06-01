namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ExtraColorSchemeList Class.
/// </summary>
public class ExtraColorSchemeList: ModelElement
{
  public Collection<ExtraColorScheme>? ExtraColorSchemes { get; set; }
}
