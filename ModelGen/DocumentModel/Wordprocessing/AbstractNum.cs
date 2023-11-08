namespace DocumentModel.Wordprocessing;


/// <summary>
///   Abstract Numbering Definition.
/// </summary>
public partial class AbstractNum: ModelElement<DXW.AbstractNum>
{
  public AbstractNum(): base(){ }
  
  public AbstractNum(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AbstractNum(DXW.AbstractNum openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Abstract Numbering Definition ID
  /// </summary>
  [DataMember]
  public Int32? AbstractNumberId
  {
    get
    {
      return _Element?.AbstractNumberId?.Value;
    }
    set
    {
      _ExistingElement.AbstractNumberId = value;
    }
  }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Identifier.
  /// </summary>
  [DataMember]
  public DMW.Nsid? Nsid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Nsid>();
      if (element != null)
        return NsidConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Nsid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NsidConverter.CreateOpenXmlElement<DXW.Nsid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Type.
  /// </summary>
  [DataMember]
  public DMW.MultiLevelKind? MultiLevelType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(_ExistingElement.GetFirstChild<DXW.MultiLevelType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MultiLevelType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>(itemElement, (DMW.MultiLevelKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.MultiLevelType, DocumentFormat.OpenXml.Wordprocessing.MultiLevelValues, DMW.MultiLevelKind>((DMW.MultiLevelKind)value));
    }
  }
  
  
  /// <summary>
  ///   Numbering Template Code.
  /// </summary>
  [DataMember]
  public DMW.TemplateCode? TemplateCode
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TemplateCode>();
      if (element != null)
        return TemplateCodeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TemplateCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TemplateCodeConverter.CreateOpenXmlElement<DXW.TemplateCode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Abstract Numbering Definition Name.
  /// </summary>
  [DataMember]
  public DMW.AbstractNumDefinitionName? AbstractNumDefinitionName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AbstractNumDefinitionName>();
      if (element != null)
        return AbstractNumDefinitionNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AbstractNumDefinitionName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AbstractNumDefinitionNameConverter.CreateOpenXmlElement<DXW.AbstractNumDefinitionName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Numbering Style Definition.
  /// </summary>
  [DataMember]
  public DMW.StyleLink? StyleLink
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StyleLink>();
      if (element != null)
        return StyleLinkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StyleLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleLinkConverter.CreateOpenXmlElement<DXW.StyleLink>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Numbering Style Reference.
  /// </summary>
  [DataMember]
  public DMW.NumberingStyleLink? NumberingStyleLink
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NumberingStyleLink>();
      if (element != null)
        return NumberingStyleLinkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingStyleLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingStyleLinkConverter.CreateOpenXmlElement<DXW.NumberingStyleLink>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
