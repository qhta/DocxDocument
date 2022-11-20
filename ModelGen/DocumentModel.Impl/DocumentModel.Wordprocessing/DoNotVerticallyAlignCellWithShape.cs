namespace DocumentModel.Wordprocessing;

/// <summary>
/// Don't Vertically Align Cells Containing Floating Objects.
/// </summary>
public class DoNotVerticallyAlignCellWithShape: IDoNotVerticallyAlignCellWithShape
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
