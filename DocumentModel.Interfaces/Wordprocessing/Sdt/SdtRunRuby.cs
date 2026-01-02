namespace DocumentModel.Wordprocessing;
/// <summary>
///   Counterpart of <see cref="SdtRun"/> class in Ruby domain.
/// </summary>
public class SdtRunRuby: ElementCollection<IRubyContent>, IRubyContent
{
  /// <summary>
  ///  Specifies the set of properties which shall be applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }
  /// <summary>
  /// Specifies the properties which shall be applied to the physical character which delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}