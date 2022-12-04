namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the NumberingProperties Class.
/// </summary>
public class NumberingProperties
{
  /// <summary>
  /// Previous Paragraph Numbering Properties.
  /// </summary>
  public NumberingChange? NumberingChange
  {
    get;
    set;
  }
  
  /// <summary>
  /// Inserted Numbering Properties.
  /// </summary>
  public Boolean? Inserted
  {
    get;
    set;
  }
  
}
