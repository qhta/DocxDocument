namespace DocumentModel.Drawing.Charts;

/// <summary>
/// The way that blank cells are plotted on a chart..
/// </summary>
public interface IDisplayBlanksAs // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Display Blanks As Value
  /// </summary>
  public DisplayBlanksAsValues? Val { get ; set; }
  
}
