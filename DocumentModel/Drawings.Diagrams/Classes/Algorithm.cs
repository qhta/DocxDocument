namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Algorithm.
/// </summary>
public class Algorithm: ModelElement
{
  /// <summary>
  ///   Algorithm Type
  /// </summary>
  public AlgorithmKind? Type { get; set; }

  /// <summary>
  ///   IRevision Number
  /// </summary>
  public UInt32? IRevision { get; set; }

  public Collection<Parameter>? Parameters { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
