namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public partial class UpDownBars: ModelElement<DXDC.UpDownBars>
{
  public UpDownBars(): base(){ }
  
  public UpDownBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpDownBars(DXDC.UpDownBars openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gap Width.
  /// </summary>
  [DataMember]
  public DMDC.GapWidth? GapWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.GapWidth>();
      if (element != null)
        return GapWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.GapWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GapWidthConverter.CreateOpenXmlElement<DXDC.GapWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Up Bars.
  /// </summary>
  [DataMember]
  public DMDC.UpBars? UpBars
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.UpBars>();
      if (element != null)
        return UpBarsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.UpBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpBarsConverter.CreateOpenXmlElement<DXDC.UpBars>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Down Bars.
  /// </summary>
  [DataMember]
  public DMDC.DownBars? DownBars
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DownBars>();
      if (element != null)
        return DownBarsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DownBars>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DownBarsConverter.CreateOpenXmlElement<DXDC.DownBars>(value);
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
