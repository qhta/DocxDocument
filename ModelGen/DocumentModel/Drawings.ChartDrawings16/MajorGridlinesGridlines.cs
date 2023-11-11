namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MajorGridlinesGridlines Class.
/// </summary>
public partial class MajorGridlinesGridlines: ModelElement<DXO16DCD.MajorGridlinesGridlines>
{
  public MajorGridlinesGridlines(): base(){ }
  
  public MajorGridlinesGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorGridlinesGridlines(DXO16DCD.MajorGridlinesGridlines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>(value);
    }
  }
  
}
