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
      return _Element?.GetObject<DMDC.NoEndCap,DXDC.NoEndCap>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NoEndCap,DXDC.NoEndCap>(value);
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
      return _Element?.GetObject<DMDC.Plus,DXDC.Plus>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Plus,DXDC.Plus>(value);
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
      return _Element?.GetObject<DMDC.Minus,DXDC.Minus>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Minus,DXDC.Minus>(value);
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
      return _Element?.GetObject<DMDC.ErrorBarValue,DXDC.ErrorBarValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ErrorBarValue,DXDC.ErrorBarValue>(value);
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
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
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
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
