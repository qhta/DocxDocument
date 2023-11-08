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
      var element = _Element?.GetFirstChild<DXDDD.DataModel>();
      if (element != null)
        return DataModelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.DataModel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelConverter.CreateOpenXmlElement<DXDDD.DataModel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
