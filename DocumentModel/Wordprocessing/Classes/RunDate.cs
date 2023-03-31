namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents a date element of text run.
/// </summary>
public class RunDate: ModelElement, IRunElement
{
  /// <summary>
  /// Specifies, which part of date is presented
  /// </summary>
  [DefaultValue(DatePart.Full)]
  public DatePart Part { get; set; }

  /// <summary>
  ///   Indicates whether this element is long.
  ///   Default - short.
  /// </summary>
  [DefaultValue(false)]
  public bool IsLong {get; set; }

}