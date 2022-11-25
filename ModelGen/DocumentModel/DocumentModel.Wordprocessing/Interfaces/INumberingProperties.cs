namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public interface INumberingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public System.Int32? NumberingLevelReference { get ; set; }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public System.Int32? NumberingId { get ; set; }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.INumberingChange? NumberingChange { get ; set; }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ITrackChangeType? Inserted { get ; set; }
  
}
