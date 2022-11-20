namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Include Content in Text Boxes, Footnotes, and Endnotes in Document Statistics.
/// </summary>
public class DoNotIncludeSubdocsInStats: IDoNotIncludeSubdocsInStats
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
