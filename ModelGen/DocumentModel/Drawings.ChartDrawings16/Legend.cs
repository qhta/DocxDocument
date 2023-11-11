namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Legend Class.
/// </summary>
public partial class Legend: ModelElement<DXO16DCD.Legend>
{
  public Legend(): base(){ }
  
  public Legend(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Legend(DXO16DCD.Legend openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Overlay
  {
    get
    {
      return _Element?.Overlay?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Overlay = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Overlay = null;
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get
    {
      return _Element?.GetObject<DMDCD16.TxPrTextBody,DXO16DCD.TxPrTextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.TxPrTextBody,DXO16DCD.TxPrTextBody>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
