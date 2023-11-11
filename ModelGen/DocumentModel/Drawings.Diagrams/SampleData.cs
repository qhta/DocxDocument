namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the SampleData Class.
/// </summary>
public partial class SampleData: ModelElement<DXDDD.SampleData>
{
  public SampleData(): base(){ }
  
  public SampleData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SampleData(DXDDD.SampleData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDD.DataModel? DataModel
  {
    get
    {
      return _Element?.GetObject<DMDD.DataModel,DXDDD.DataModel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.DataModel,DXDDD.DataModel>(value);
    }
  }
  
}
