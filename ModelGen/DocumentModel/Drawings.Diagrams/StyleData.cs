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
