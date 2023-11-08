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
      var element = _Element?.GetFirstChild<DXDC.LeftMode>();
      if (element != null)
        return LeftModeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.LeftMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftModeConverter.CreateOpenXmlElement<DXDC.LeftMode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.TopMode>();
      if (element != null)
        return TopModeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TopMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopModeConverter.CreateOpenXmlElement<DXDC.TopMode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.WidthMode>();
      if (element != null)
        return WidthModeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.WidthMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WidthModeConverter.CreateOpenXmlElement<DXDC.WidthMode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.HeightMode>();
      if (element != null)
        return HeightModeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.HeightMode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeightModeConverter.CreateOpenXmlElement<DXDC.HeightMode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Left>();
      if (element != null)
        return LeftConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Left>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftConverter.CreateOpenXmlElement<DXDC.Left>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Top>();
      if (element != null)
        return TopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Top>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopConverter.CreateOpenXmlElement<DXDC.Top>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Width>();
      if (element != null)
        return WidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Width>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WidthConverter.CreateOpenXmlElement<DXDC.Width>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Height>();
      if (element != null)
        return HeightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Height>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeightConverter.CreateOpenXmlElement<DXDC.Height>(value);
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
