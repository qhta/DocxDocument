namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Literal.
/// </summary>
public partial class NumberLiteral: ModelElement<DXDC.NumberLiteral>
{
  public NumberLiteral(): base(){ }
  
  public NumberLiteral(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberLiteral(DXDC.NumberLiteral openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.FormatCode>();
      if (element != null)
        return FormatCodeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.FormatCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatCodeConverter.CreateOpenXmlElement<DXDC.FormatCode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PointCount>();
      if (element != null)
        return PointCountConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PointCountConverter.CreateOpenXmlElement<DXDC.PointCount>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
