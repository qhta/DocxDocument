namespace DocumentModel.Office2016.Drawing.Command;

public interface IHlinkHoverHyperlinkProps // : DocumentFormat.OpenXml.Office2016.Drawing.Command.OpenXmlHyperlinkPropsElement
{
  public string? Source { get ; set; }
  
  public string? Action { get ; set; }
  
  public string? TgtFrame { get ; set; }
  
  public string? Tooltip { get ; set; }
  
  public bool? HighlightClick { get ; set; }
  
  public bool? EndSnd { get ; set; }
  
  public string? SndName { get ; set; }
  
  public ISndDataImgData? SndDataImgData { get ; set; }
  
}
