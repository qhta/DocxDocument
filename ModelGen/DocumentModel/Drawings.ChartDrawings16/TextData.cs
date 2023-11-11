namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TextData Class.
/// </summary>
public partial class TextData: ModelElement<DXO16DCD.TextData>
{
  public TextData(): base(){ }
  
  public TextData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextData(DXO16DCD.TextData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.Formula? Formula
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Formula,DXO16DCD.Formula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Formula,DXO16DCD.Formula>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.VXsdstring? VXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.VXsdstring,DXO16DCD.VXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.VXsdstring,DXO16DCD.VXsdstring>(value);
    }
  }
  
}
