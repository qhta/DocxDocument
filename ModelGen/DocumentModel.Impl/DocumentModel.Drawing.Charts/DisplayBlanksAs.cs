namespace DocumentModel.Drawing.Charts;

/// <summary>
/// The way that blank cells are plotted on a chart..
/// </summary>
public class DisplayBlanksAs: IDisplayBlanksAs
{
  /// <summary>
  /// Display Blanks As Value
  /// </summary>
  public DocumentModel.Drawing.Charts.DisplayBlanksAsValues? Val
  {
    get;
    set;
  }
  
}
