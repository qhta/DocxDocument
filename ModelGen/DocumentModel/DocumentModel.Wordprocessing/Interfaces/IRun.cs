namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  public IHexBinaryValue? RsidRunProperties { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run Deletion
  /// </summary>
  public IHexBinaryValue? RsidRunDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run
  /// </summary>
  public IHexBinaryValue? RsidRunAddition { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunProperties? RunProperties { get ; set; }
  
}
