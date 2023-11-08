namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ErrorBars Class.
/// </summary>
public partial class ErrorBars: ModelElement<DXDC.ErrorBars>
{
  public ErrorBars(): base(){ }
  
  public ErrorBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ErrorBars(DXDC.ErrorBars openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Error Bar Direction.
  /// </summary>
  [DataMember]
  public DMDC.ErrorBarDirectionKind? ErrorDirection
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>(_ExistingElement.GetFirstChild<DXDC.ErrorDirection>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ErrorDirection>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>(itemElement, (DMDC.ErrorBarDirectionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ErrorDirection, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarDirectionValues, DMDC.ErrorBarDirectionKind>((DMDC.ErrorBarDirectionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Error Bar Type.
  /// </summary>
  [DataMember]
  public DMDC.ErrorBarKind? ErrorBarType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>(_ExistingElement.GetFirstChild<DXDC.ErrorBarType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ErrorBarType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>(itemElement, (DMDC.ErrorBarKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ErrorBarType, DocumentFormat.OpenXml.Drawing.Charts.ErrorBarValues, DMDC.ErrorBarKind>((DMDC.ErrorBarKind)value));
    }
  }
  
  
  /// <summary>
  ///   Error Bar Value Type.
  /// </summary>
  [DataMember]
  public DMDC.ErrorKind? ErrorBarValueType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>(_ExistingElement.GetFirstChild<DXDC.ErrorBarValueType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ErrorBarValueType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>(itemElement, (DMDC.ErrorKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ErrorBarValueType, DocumentFormat.OpenXml.Drawing.Charts.ErrorValues, DMDC.ErrorKind>((DMDC.ErrorKind)value));
    }
  }
  
  
  /// <summary>
  ///   No End Cap.
  /// </summary>
  [DataMember]
  public DMDC.NoEndCap? NoEndCap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NoEndCap>();
      if (element != null)
        return NoEndCapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NoEndCap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoEndCapConverter.CreateOpenXmlElement<DXDC.NoEndCap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Plus.
  /// </summary>
  [DataMember]
  public DMDC.Plus? Plus
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Plus>();
      if (element != null)
        return PlusConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Plus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlusConverter.CreateOpenXmlElement<DXDC.Plus>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Minus.
  /// </summary>
  [DataMember]
  public DMDC.Minus? Minus
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Minus>();
      if (element != null)
        return MinusConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Minus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinusConverter.CreateOpenXmlElement<DXDC.Minus>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Error Bar Value.
  /// </summary>
  [DataMember]
  public DMDC.ErrorBarValue? ErrorBarValue
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ErrorBarValue>();
      if (element != null)
        return ErrorBarValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ErrorBarValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ErrorBarValueConverter.CreateOpenXmlElement<DXDC.ErrorBarValue>(value);
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
