namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Marker.
/// </summary>
public partial class Marker: ModelElement<DXDC.Marker>
{
  public Marker(): base(){ }
  
  public Marker(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Marker(DXDC.Marker openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Symbol.
  /// </summary>
  [DataMember]
  public DMDC.MarkerStyleKind? Symbol
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(_ExistingElement.GetFirstChild<DXDC.Symbol>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Symbol>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>(itemElement, (DMDC.MarkerStyleKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Symbol, DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DMDC.MarkerStyleKind>((DMDC.MarkerStyleKind)value));
    }
  }
  
  
  /// <summary>
  ///   Size.
  /// </summary>
  [DataMember]
  public Byte? Size
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.Size>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.Size,System.Byte>(_ExistingElement, value);
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
