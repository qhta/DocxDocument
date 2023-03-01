namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a date element of text run.
/// </summary>
public class RunDate: RunElement
{
  /// <summary>
  /// Specifies, which part of date is presented
  /// </summary>
  [DefaultValue(DatePart.Full)]
  [XmlAttribute] public DatePart Part { get; set; }

  /// <summary>
  ///   Indicates whether this element is long.
  ///   Default - short.
  /// </summary>
  [DefaultValue(false)]
  [XmlAttribute] public bool IsLong {get; set; }

}