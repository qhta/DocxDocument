namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Manual Layout.
/// </summary>
public partial class ManualLayout: ModelElement<DXDC.ManualLayout>
{
  public ManualLayout(): base(){ }
  
  public ManualLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ManualLayout(DXDC.ManualLayout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Layout Target.
  /// </summary>
  [DataMember]
  public DMDC.LayoutTargetKind? LayoutTarget
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>(_ExistingElement.GetFirstChild<DXDC.LayoutTarget>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.LayoutTarget>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>(itemElement, (DMDC.LayoutTargetKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.LayoutTarget, DocumentFormat.OpenXml.Drawing.Charts.LayoutTargetValues, DMDC.LayoutTargetKind>((DMDC.LayoutTargetKind)value));
    }
  }
  
  
  /// <summary>
  ///   Left Mode.
  /// </summary>
  [DataMember]
  public DMDC.LeftMode? LeftMode
  {
    get
    {
      return _Element?.GetObject<DMDC.LeftMode,DXDC.LeftMode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.LeftMode,DXDC.LeftMode>(value);
    }
  }
  
  
  /// <summary>
  ///   Top Mode.
  /// </summary>
  [DataMember]
  public DMDC.TopMode? TopMode
  {
    get
    {
      return _Element?.GetObject<DMDC.TopMode,DXDC.TopMode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TopMode,DXDC.TopMode>(value);
    }
  }
  
  
  /// <summary>
  ///   Width Mode.
  /// </summary>
  [DataMember]
  public DMDC.WidthMode? WidthMode
  {
    get
    {
      return _Element?.GetObject<DMDC.WidthMode,DXDC.WidthMode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.WidthMode,DXDC.WidthMode>(value);
    }
  }
  
  
  /// <summary>
  ///   Height Mode.
  /// </summary>
  [DataMember]
  public DMDC.HeightMode? HeightMode
  {
    get
    {
      return _Element?.GetObject<DMDC.HeightMode,DXDC.HeightMode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.HeightMode,DXDC.HeightMode>(value);
    }
  }
  
  
  /// <summary>
  ///   Left.
  /// </summary>
  [DataMember]
  public DMDC.Left? Left
  {
    get
    {
      return _Element?.GetObject<DMDC.Left,DXDC.Left>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Left,DXDC.Left>(value);
    }
  }
  
  
  /// <summary>
  ///   Top.
  /// </summary>
  [DataMember]
  public DMDC.Top? Top
  {
    get
    {
      return _Element?.GetObject<DMDC.Top,DXDC.Top>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Top,DXDC.Top>(value);
    }
  }
  
  
  /// <summary>
  ///   Width.
  /// </summary>
  [DataMember]
  public DMDC.Width? Width
  {
    get
    {
      return _Element?.GetObject<DMDC.Width,DXDC.Width>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Width,DXDC.Width>(value);
    }
  }
  
  
  /// <summary>
  ///   Height.
  /// </summary>
  [DataMember]
  public DMDC.Height? Height
  {
    get
    {
      return _Element?.GetObject<DMDC.Height,DXDC.Height>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Height,DXDC.Height>(value);
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
