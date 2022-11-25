namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRunProperties { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run Deletion
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRunDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRunAddition { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
}
