namespace DocumentModel.Drawings.Charts;


/// <summary>
///   True if the chart automatic title has been deleted..
/// </summary>
public partial class AutoTitleDeleted: ModelElement<DXDC.AutoTitleDeleted>
{
  public AutoTitleDeleted(): base(){ }
  
  public AutoTitleDeleted(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoTitleDeleted(DXDC.AutoTitleDeleted openXmlElement): base(openXmlElement) { }
  
}
