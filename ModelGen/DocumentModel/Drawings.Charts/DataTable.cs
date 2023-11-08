namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Table.
/// </summary>
public partial class DataTable: ModelElement<DXDC.DataTable>
{
  public DataTable(): base(){ }
  
  public DataTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataTable(DXDC.DataTable openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Show Horizontal Border.
  /// </summary>
  [DataMember]
  public DMDC.ShowHorizontalBorder? ShowHorizontalBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowHorizontalBorder>();
      if (element != null)
        return ShowHorizontalBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowHorizontalBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowHorizontalBorderConverter.CreateOpenXmlElement<DXDC.ShowHorizontalBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Show Vertical Border.
  /// </summary>
  [DataMember]
  public DMDC.ShowVerticalBorder? ShowVerticalBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowVerticalBorder>();
      if (element != null)
        return ShowVerticalBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowVerticalBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowVerticalBorderConverter.CreateOpenXmlElement<DXDC.ShowVerticalBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Show Outline Border.
  /// </summary>
  [DataMember]
  public DMDC.ShowOutlineBorder? ShowOutlineBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowOutlineBorder>();
      if (element != null)
        return ShowOutlineBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowOutlineBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowOutlineBorderConverter.CreateOpenXmlElement<DXDC.ShowOutlineBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Show Legend Keys.
  /// </summary>
  [DataMember]
  public DMDC.ShowKeys? ShowKeys
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowKeys>();
      if (element != null)
        return ShowKeysConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowKeys>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowKeysConverter.CreateOpenXmlElement<DXDC.ShowKeys>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartShapeProperties>();
      if (element != null)
        return ChartShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Text Properties.
  /// </summary>
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.TextProperties>();
      if (element != null)
        return TextPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
