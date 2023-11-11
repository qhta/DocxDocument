namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MajorTickMarksTickMarks Class.
/// </summary>
public partial class MajorTickMarksTickMarks: ModelElement<DXO16DCD.MajorTickMarksTickMarks>
{
  public MajorTickMarksTickMarks(): base(){ }
  
  public MajorTickMarksTickMarks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorTickMarksTickMarks(DXO16DCD.MajorTickMarksTickMarks openXmlElement): base(openXmlElement) { }
  
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
