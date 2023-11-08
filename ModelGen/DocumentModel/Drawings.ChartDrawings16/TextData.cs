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
      var element = _Element?.GetFirstChild<DXO16DCD.Formula>();
      if (element != null)
        return FormulaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulaConverter.CreateOpenXmlElement<DXO16DCD.Formula>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.VXsdstring? VXsdstring
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.VXsdstring>();
      if (element != null)
        return VXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.VXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VXsdstringConverter.CreateOpenXmlElement<DXO16DCD.VXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
