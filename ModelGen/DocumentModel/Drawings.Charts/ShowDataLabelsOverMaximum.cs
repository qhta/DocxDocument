namespace DocumentModel.Drawings.Charts;


/// <summary>
///   True if we should render datalabels over the maximum scale.
/// </summary>
public partial class ShowDataLabelsOverMaximum: ModelElement<DXDC.ShowDataLabelsOverMaximum>
{
  public ShowDataLabelsOverMaximum(): base(){ }
  
  public ShowDataLabelsOverMaximum(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowDataLabelsOverMaximum(DXDC.ShowDataLabelsOverMaximum openXmlElement): base(openXmlElement) { }
  
}
