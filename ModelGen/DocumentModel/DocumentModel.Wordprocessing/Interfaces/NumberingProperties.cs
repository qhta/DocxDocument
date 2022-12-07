namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public interface NumberingProperties
{
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public NumberingChange? NumberingChange { get ; set; }
  
}
