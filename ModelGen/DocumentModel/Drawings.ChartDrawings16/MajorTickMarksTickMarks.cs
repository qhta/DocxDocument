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
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
