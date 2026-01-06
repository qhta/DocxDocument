namespace DocumentModel.Wordprocessing;
/// <summary>
///   Counterpart of <see cref="SdtRun"/> interface in Ruby domain.
/// </summary>
public interface SdtRunRuby: IElementCollection<RubyContent>, RubyContent
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