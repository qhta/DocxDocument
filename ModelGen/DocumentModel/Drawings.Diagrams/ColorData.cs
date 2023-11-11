namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the ColorData Class.
/// </summary>
public partial class ColorData: ModelElement<DXDDD.ColorData>
{
  public ColorData(): base(){ }
  
  public ColorData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorData(DXDDD.ColorData openXmlElement): base(openXmlElement) { }
  
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
