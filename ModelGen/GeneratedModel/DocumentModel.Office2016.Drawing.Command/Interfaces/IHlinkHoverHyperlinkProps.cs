namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the HlinkHoverHyperlinkProps Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.ISndDataImgData))]
public interface IHlinkHoverHyperlinkProps // : DocumentFormat.OpenXml.Office2016.Drawing.Command.OpenXmlHyperlinkPropsElement
{
  /// <summary>
  /// source, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Source { get ; set; }
  
  /// <summary>
  /// action, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Action { get ; set; }
  
  /// <summary>
  /// tgtFrame, this property is only available in Office 2016 and later.
  /// </summary>
  public string? TgtFrame { get ; set; }
  
  /// <summary>
  /// tooltip, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Tooltip { get ; set; }
  
  /// <summary>
  /// highlightClick, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? HighlightClick { get ; set; }
  
  /// <summary>
  /// endSnd, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? EndSnd { get ; set; }
  
  /// <summary>
  /// sndName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? SndName { get ; set; }
  
  /// <summary>
  /// SndDataImgData.
  /// </summary>
  public ISndDataImgData? SndDataImgData { get ; set; }
  
}
