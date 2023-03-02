namespace DocumentModel.Math;

/// <summary>
///   Group-Character Function.
/// </summary>
public record GroupChar: DMW.ParagraphElement
{
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  public GroupCharProperties? GroupCharProperties { get; set; }

  /// <summary>
  ///   Base.
  /// </summary>
  public Base? Base { get; set; }
}