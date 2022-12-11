namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public interface TextBodyType
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public ListStyle? ListStyle { get ; set; }
  
}
