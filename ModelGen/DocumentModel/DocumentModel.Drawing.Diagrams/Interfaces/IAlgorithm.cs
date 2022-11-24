namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public interface IAlgorithm // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public AlgorithmValues? Type { get ; set; }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public UInt32? Revision { get ; set; }
  
}
