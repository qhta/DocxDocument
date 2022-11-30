namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public interface IAlgorithm // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public DocumentModel.Drawing.Diagrams.AlgorithmKind? Type { get ; set; }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public System.UInt32? Revision { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IParameter>? Parameters { get ; set; }
  
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
