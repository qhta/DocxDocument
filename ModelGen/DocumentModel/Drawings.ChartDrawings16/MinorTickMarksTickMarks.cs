namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MinorTickMarksTickMarks Class.
/// </summary>
public partial class MinorTickMarksTickMarks: ModelElement<DXO16DCD.MinorTickMarksTickMarks>
{
  public MinorTickMarksTickMarks(): base(){ }
  
  public MinorTickMarksTickMarks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorTickMarksTickMarks(DXO16DCD.MinorTickMarksTickMarks openXmlElement): base(openXmlElement) { }
  
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
