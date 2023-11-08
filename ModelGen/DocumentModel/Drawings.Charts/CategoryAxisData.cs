namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the CategoryAxisData Class.
/// </summary>
public partial class CategoryAxisData: ModelElement<DXDC.CategoryAxisData>
{
  public CategoryAxisData(): base(){ }
  
  public CategoryAxisData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CategoryAxisData(DXDC.CategoryAxisData openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.MultiLevelStringReference? MultiLevelStringReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.MultiLevelStringReference>();
      if (element != null)
        return MultiLevelStringReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MultiLevelStringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MultiLevelStringReferenceConverter.CreateOpenXmlElement<DXDC.MultiLevelStringReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumberReference>();
      if (element != null)
        return NumberReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberReferenceConverter.CreateOpenXmlElement<DXDC.NumberReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumberLiteral>();
      if (element != null)
        return NumberLiteralConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberLiteralConverter.CreateOpenXmlElement<DXDC.NumberLiteral>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StringReference>();
      if (element != null)
        return StringReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringReferenceConverter.CreateOpenXmlElement<DXDC.StringReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.StringLiteral? StringLiteral
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StringLiteral>();
      if (element != null)
        return StringLiteralConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StringLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringLiteralConverter.CreateOpenXmlElement<DXDC.StringLiteral>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
