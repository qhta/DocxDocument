namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public partial interface NumberingProperties
{
  /// <summary>
  /// Numbering Level Reference.
  /// </summary>
  public Int32? NumberingLevelReference { get; set; }
  
  /// <summary>
  /// Numbering Definition Instance Reference.
  /// </summary>
  public Int32? NumberingId { get; set; }
  
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingChange? NumberingChange { get; set; }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.TrackChangeType? Inserted { get; set; }
  
}
