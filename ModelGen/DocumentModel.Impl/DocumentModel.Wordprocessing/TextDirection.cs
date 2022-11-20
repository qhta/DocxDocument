namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextDirection Class.
/// </summary>
public class TextDirection: ITextDirection
{
  /// <summary>
  /// Direction of Text Flow
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionValues? Val
  {
    get;
    set;
  }
  
}
