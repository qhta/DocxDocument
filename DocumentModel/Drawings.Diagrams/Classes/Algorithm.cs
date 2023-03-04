namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Algorithm.
/// </summary>
public class Algorithm
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