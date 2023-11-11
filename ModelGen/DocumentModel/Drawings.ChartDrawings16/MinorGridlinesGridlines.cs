namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MinorGridlinesGridlines Class.
/// </summary>
public partial class MinorGridlinesGridlines: ModelElement<DXO16DCD.MinorGridlinesGridlines>
{
  public MinorGridlinesGridlines(): base(){ }
  
  public MinorGridlinesGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorGridlinesGridlines(DXO16DCD.MinorGridlinesGridlines openXmlElement): base(openXmlElement) { }
  
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
