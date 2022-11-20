namespace DocumentModel.Presentation;

/// <summary>
/// Paragraph Text Range.
/// </summary>
public class ParagraphIndexRange: IParagraphIndexRange
{
  /// <summary>
  /// Start
  /// </summary>
  public uint? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// End
  /// </summary>
  public uint? End
  {
    get;
    set;
  }
  
}
