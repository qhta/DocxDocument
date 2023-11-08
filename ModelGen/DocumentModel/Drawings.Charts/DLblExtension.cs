namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DLblExtension Class.
/// </summary>
public partial class DLblExtension: ModelElement<DXDC.DLblExtension>
{
  public DLblExtension(): base(){ }
  
  public DLblExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DLblExtension(DXDC.DLblExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.DataLabelFieldTable? DataLabelFieldTable
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.DataLabelFieldTable>();
      if (element != null)
        return DataLabelFieldTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.DataLabelFieldTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelFieldTableConverter.CreateOpenXmlElement<DXO13DC.DataLabelFieldTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.ExceptionForSave? ExceptionForSave
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ExceptionForSave>();
      if (element != null)
        return ExceptionForSaveConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ExceptionForSave>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExceptionForSaveConverter.CreateOpenXmlElement<DXO13DC.ExceptionForSave>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.ShowDataLabelsRange? ShowDataLabelsRange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ShowDataLabelsRange>();
      if (element != null)
        return ShowDataLabelsRangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ShowDataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowDataLabelsRangeConverter.CreateOpenXmlElement<DXO13DC.ShowDataLabelsRange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO13DC.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.Layout? Layout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.Layout>();
      if (element != null)
        return LayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DXO13DC.Layout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
