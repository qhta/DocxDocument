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
      var element = _Element?.GetFirstChild<DXO16DCD.NumberFormat>();
      if (element != null)
        return NumberFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.NumberFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberFormatConverter.CreateOpenXmlElement<DXO16DCD.NumberFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.TxPrTextBody>();
      if (element != null)
        return TxPrTextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TxPrTextBodyConverter.CreateOpenXmlElement<DXO16DCD.TxPrTextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.DataLabelVisibilities>();
      if (element != null)
        return DataLabelVisibilitiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.DataLabelVisibilities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelVisibilitiesConverter.CreateOpenXmlElement<DXO16DCD.DataLabelVisibilities>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.SeparatorXsdstring>();
      if (element != null)
        return SeparatorXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.SeparatorXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeparatorXsdstringConverter.CreateOpenXmlElement<DXO16DCD.SeparatorXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
