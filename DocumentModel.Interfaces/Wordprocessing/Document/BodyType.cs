namespace DocumentModel.Wordprocessing;
/// <summary>
///   Common interface for <see cref="Body"/> and <see cref="DocPartBody"/> elements.
/// </summary>
public interface BodyType : Story
{
  /// <summary>
  /// Collection of sections which is recollected from ISectionProperties elements
  /// </summary>
  public Sections? Sections { get; set; }

}