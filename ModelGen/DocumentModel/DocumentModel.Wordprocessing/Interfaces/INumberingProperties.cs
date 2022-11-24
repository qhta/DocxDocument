namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public interface INumberingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public Int32Value? NumberingLevelReference { get ; set; }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public INumberingId? NumberingId { get ; set; }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public INumberingChange? NumberingChange { get ; set; }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public Inserted? Inserted { get ; set; }
  
}
