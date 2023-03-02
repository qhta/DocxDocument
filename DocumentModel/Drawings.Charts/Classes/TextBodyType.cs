namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the TextBodyType Class.
/// </summary>
public record TextBodyType
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   Text List Styles.
  /// </summary>
  public ListStyle? ListStyle { get; set; }
}