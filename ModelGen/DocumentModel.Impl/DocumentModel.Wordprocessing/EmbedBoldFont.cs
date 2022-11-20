namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EmbedBoldFont Class.
/// </summary>
public class EmbedBoldFont: IEmbedBoldFont
{
  /// <summary>
  /// fontKey
  /// </summary>
  public string? FontKey
  {
    get;
    set;
  }
  
  /// <summary>
  /// subsetted
  /// </summary>
  public bool? Subsetted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
