namespace DocumentModel.Drawing;

/// <summary>
/// Algorithm.
/// </summary>
public interface IAlgorithm // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public DocumentModel.Drawing.AlgorithmKind? Type { get ; set; }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public System.UInt32? Revision { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IParameter>? Parameters { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
