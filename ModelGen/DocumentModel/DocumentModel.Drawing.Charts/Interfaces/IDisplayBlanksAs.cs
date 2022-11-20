namespace DocumentModel.Drawing.Charts;

/// <summary>
/// The way that blank cells are plotted on a chart..
/// </summary>
public interface IDisplayBlanksAs // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Display Blanks As Value
  /// </summary>
  public DocumentModel.Drawing.Charts.DisplayBlanksAsValues? Val { get ; set; }
  
}
