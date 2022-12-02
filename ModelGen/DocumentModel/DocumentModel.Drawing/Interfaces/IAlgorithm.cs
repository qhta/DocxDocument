namespace DocumentModel.Drawing;

/// <summary>
/// Algorithm.
/// </summary>
public interface IAlgorithm // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public AlgorithmKind? Type { get ; set; }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public UInt32? Revision { get ; set; }
  
  public Collection<IParameter>? Parameters { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
