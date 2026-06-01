namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TextBodyType Class.
/// </summary>
public class TextBodyType: ModelElement
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   Text IList IStyles.
  /// </summary>
  public ListStyle? ListStyle { get; set; }
}
