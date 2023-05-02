namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CustomColorList Class.
/// </summary>
public class CustomColorList: ModelElement
{
  public Collection<CustomColor>? CustomColors { get; set; }
}