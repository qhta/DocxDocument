namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Constraint.
/// </summary>
public partial class Constraint: ModelElement<DXDDD.Constraint>
{
  public Constraint(): base(){ }
  
  public Constraint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Constraint(DXDDD.Constraint openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Reference For Name
  /// </summary>
  [DataMember]
  public String? ReferenceForName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ReferenceForName);
    }
    set
    {
      _ExistingElement.ReferenceForName = StringValueConverter.CreateStringValue(value);
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
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.ExtensionList,DXDDD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ExtensionList,DXDDD.ExtensionList>(value);
    }
  }
  
}
