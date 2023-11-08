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
