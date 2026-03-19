namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Algorithm.
/// </summary>
[OpenXmlType(typeof(DXDD.Algorithm))]
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
  public Parameters? Parameters { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}