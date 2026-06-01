namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TextBody Class.
/// </summary>
public class TextBody: ModelElement
{
  /// <summary>
  ///   Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   Text IList IStyles.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  public IParagraph? IParagraph { get; set; }
}
