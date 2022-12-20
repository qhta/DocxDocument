namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public partial interface TextBodyType
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
}
