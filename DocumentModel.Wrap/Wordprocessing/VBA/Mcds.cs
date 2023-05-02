namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Mcds Class.
/// </summary>
public class Mcds: ModelElement
{
  public Collection<Mcd>? Items { get; set; }
}