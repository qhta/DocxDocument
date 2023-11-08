namespace DocumentModel.Wordprocessing;


/// <summary>
///   View Merged Data Within Document.
/// </summary>
public partial class ViewMergedData: ModelElement<DXW.ViewMergedData>
{
  public ViewMergedData(): base(){ }
  
  public ViewMergedData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ViewMergedData(DXW.ViewMergedData openXmlElement): base(openXmlElement) { }
  
}
