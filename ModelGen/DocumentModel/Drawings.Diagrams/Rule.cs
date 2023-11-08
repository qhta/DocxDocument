namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Rule.
/// </summary>
public partial class Rule: ModelElement<DXDDD.Rule>
{
  public Rule(): base(){ }
  
  public Rule(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rule(DXDDD.Rule openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   For Name
  /// </summary>
  [DataMember]
  public String? ForName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ForName);
    }
    set
    {
      _ExistingElement.ForName = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public Double? Val
  {
    get
    {
      return _Element?.Val?.Value;
    }
    set
    {
      _ExistingElement.Val = value;
    }
  }
  
  
  /// <summary>
  ///   Factor
  /// </summary>
  [DataMember]
  public Double? Fact
  {
    get
    {
      return _Element?.Fact?.Value;
    }
    set
    {
      _ExistingElement.Fact = value;
    }
  }
  
  
  /// <summary>
  ///   Max Value
  /// </summary>
  [DataMember]
  public Double? Max
  {
    get
    {
      return _Element?.Max?.Value;
    }
    set
    {
      _ExistingElement.Max = value;
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDDD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
