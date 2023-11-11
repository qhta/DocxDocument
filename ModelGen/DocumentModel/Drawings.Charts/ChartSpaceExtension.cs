namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartSpaceExtension Class.
/// </summary>
public partial class ChartSpaceExtension: ModelElement<DXDC.ChartSpaceExtension>
{
  public ChartSpaceExtension(): base(){ }
  
  public ChartSpaceExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartSpaceExtension(DXDC.ChartSpaceExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC10.PivotOptions? PivotOptions
  {
    get
    {
      return _Element?.GetObject<DMDC10.PivotOptions,DXO10DC.PivotOptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.PivotOptions,DXO10DC.PivotOptions>(value);
    }
  }
  
  [DataMember]
  public DMDC10.SketchOptions? SketchOptions
  {
    get
    {
      return _Element?.GetObject<DMDC10.SketchOptions,DXO10DC.SketchOptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.SketchOptions,DXO10DC.SketchOptions>(value);
    }
  }
  
  [DataMember]
  public DMDC13.PivotSource? PivotSource
  {
    get
    {
      return _Element?.GetObject<DMDC13.PivotSource,DXO13DC.PivotSource>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.PivotSource,DXO13DC.PivotSource>(value);
    }
  }
  
}
