namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public partial interface BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Wordprocessing.Vml.BorderKind? Type { get; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public Int32? Width { get; set; }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public Boolean? Shadow { get; set; }
  
}
