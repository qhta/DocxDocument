namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  ///   Revision Number
  /// </summary>
  public UInt32? Revision { get; set; }

  public Collection<Parameter>? Parameters { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}