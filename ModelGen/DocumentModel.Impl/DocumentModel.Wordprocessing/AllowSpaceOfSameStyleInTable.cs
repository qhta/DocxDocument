namespace DocumentModel.Wordprocessing;

/// <summary>
/// Allow Contextual Spacing of Paragraphs in Tables.
/// </summary>
public class AllowSpaceOfSameStyleInTable: IAllowSpaceOfSameStyleInTable
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
