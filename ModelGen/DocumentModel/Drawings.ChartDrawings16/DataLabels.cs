namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the DataLabels Class.
/// </summary>
public partial class DataLabels: ModelElement<DXO16DCD.DataLabels>
{
  public DataLabels(): base(){ }
  
  public DataLabels(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabels(DXO16DCD.DataLabels openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NumberFormat.
  /// </summary>
  [DataMember]
  public DMDCD16.NumberFormat? NumberFormat
  {
    get
    {
      return _Element?.GetObject<DMDCD16.NumberFormat,DXO16DCD.NumberFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.NumberFormat,DXO16DCD.NumberFormat>(value);
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
  ///   DataLabelVisibilities.
  /// </summary>
  [DataMember]
  public DMDCD16.DataLabelVisibilities? DataLabelVisibilities
  {
    get
    {
      return _Element?.GetObject<DMDCD16.DataLabelVisibilities,DXO16DCD.DataLabelVisibilities>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.DataLabelVisibilities,DXO16DCD.DataLabelVisibilities>(value);
    }
  }
  
  
  /// <summary>
  ///   SeparatorXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.SeparatorXsdstring? SeparatorXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.SeparatorXsdstring,DXO16DCD.SeparatorXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.SeparatorXsdstring,DXO16DCD.SeparatorXsdstring>(value);
    }
  }
  
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
