namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Algorithm.
/// </summary>
[OpenXmlType(typeof(DXDD.Algorithm))]
/// <summary>
/// Represents the Algorithm.
/// </summary>
public class Algorithm: ModelElement<DXDD.Algorithm>
{
  /// <summary>
  ///   Algorithm Type
  /// </summary>
  public AlgorithmType? Type { get; set; }
  /// <summary>
  ///   Revision Number
  /// </summary>
  public UInt32? Revision { get; set; }
  /// <summary>
  /// Parameters.
  /// </summary>
  public Parameters? Parameters { get; set; }
  /// <summary>
  /// Extension List.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}

