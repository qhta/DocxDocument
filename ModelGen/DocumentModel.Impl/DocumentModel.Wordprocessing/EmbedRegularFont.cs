namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EmbedRegularFont Class.
/// </summary>
public class EmbedRegularFont: IEmbedRegularFont
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
