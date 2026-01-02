namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines SdtElement - the base class for the sdt elements.
/// </summary>
public class SdtElement: ModelElement
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