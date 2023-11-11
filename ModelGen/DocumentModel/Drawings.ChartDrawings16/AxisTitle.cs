namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the AxisTitle Class.
/// </summary>
public partial class AxisTitle: ModelElement<DXO16DCD.AxisTitle>
{
  public AxisTitle(): base(){ }
  
  public AxisTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisTitle(DXO16DCD.AxisTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMDCD16.Text? Text
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Text,DXO16DCD.Text>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Text,DXO16DCD.Text>(value);
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
