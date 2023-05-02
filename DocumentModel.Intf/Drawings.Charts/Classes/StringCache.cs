namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StringCache Class.
/// </summary>
public class StringCache: ModelElement
{
  public UInt32? PointCount { get; set; }

  public Collection<StringPoint>? StringPoints { get; set; }

  public StrDataExtensionList? StrDataExtensionList { get; set; }
}