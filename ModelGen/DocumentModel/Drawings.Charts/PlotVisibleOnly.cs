namespace DocumentModel.Drawings.Charts;


/// <summary>
///   True if only visible cells are plotted..
/// </summary>
public partial class PlotVisibleOnly: ModelElement<DXDC.PlotVisibleOnly>
{
  public PlotVisibleOnly(): base(){ }
  
  public PlotVisibleOnly(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotVisibleOnly(DXDC.PlotVisibleOnly openXmlElement): base(openXmlElement) { }
  
}
