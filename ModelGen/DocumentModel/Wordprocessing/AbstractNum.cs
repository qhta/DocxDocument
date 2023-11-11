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
      return _Element?.GetObject<DMW.Nsid,DXW.Nsid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Nsid,DXW.Nsid>(value);
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
      return _Element?.GetObject<DMW.TemplateCode,DXW.TemplateCode>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TemplateCode,DXW.TemplateCode>(value);
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
      return _Element?.GetObject<DMW.AbstractNumDefinitionName,DXW.AbstractNumDefinitionName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.AbstractNumDefinitionName,DXW.AbstractNumDefinitionName>(value);
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
      return _Element?.GetObject<DMW.StyleLink,DXW.StyleLink>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StyleLink,DXW.StyleLink>(value);
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
      return _Element?.GetObject<DMW.NumberingStyleLink,DXW.NumberingStyleLink>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NumberingStyleLink,DXW.NumberingStyleLink>(value);
    }
  }
  
}
