namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the StyleData Class.
/// </summary>
public partial class StyleData: ModelElement<DXDDD.StyleData>
{
  public StyleData(): base(){ }
  
  public StyleData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleData(DXDDD.StyleData openXmlElement): base(openXmlElement) { }
  
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
