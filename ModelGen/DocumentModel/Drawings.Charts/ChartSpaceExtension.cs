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
      var element = _Element?.GetFirstChild<DXO10DC.PivotOptions>();
      if (element != null)
        return PivotOptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.PivotOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotOptionsConverter.CreateOpenXmlElement<DXO10DC.PivotOptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC10.SketchOptions? SketchOptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.SketchOptions>();
      if (element != null)
        return SketchOptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.SketchOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SketchOptionsConverter.CreateOpenXmlElement<DXO10DC.SketchOptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.PivotSource? PivotSource
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.PivotSource>();
      if (element != null)
        return PivotSourceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.PivotSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotSourceConverter.CreateOpenXmlElement<DXO13DC.PivotSource>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
