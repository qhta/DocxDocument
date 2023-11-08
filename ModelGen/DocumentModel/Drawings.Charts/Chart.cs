namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Chart Class.
/// </summary>
public partial class Chart: ModelElement<DXDC.Chart>
{
  public Chart(): base(){ }
  
  public Chart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Chart(DXDC.Chart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Title data and formatting.
  /// </summary>
  [DataMember]
  public DMDC.Title? Title
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Title>();
      if (element != null)
        return TitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Title>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitleConverter.CreateOpenXmlElement<DXDC.Title>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   True if the chart automatic title has been deleted..
  /// </summary>
  [DataMember]
  public DMDC.AutoTitleDeleted? AutoTitleDeleted
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.AutoTitleDeleted>();
      if (element != null)
        return AutoTitleDeletedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AutoTitleDeleted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoTitleDeletedConverter.CreateOpenXmlElement<DXDC.AutoTitleDeleted>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   pivot chart format persistence data.
  /// </summary>
  [DataMember]
  public DMDC.PivotFormats? PivotFormats
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PivotFormats>();
      if (element != null)
        return PivotFormatsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PivotFormats>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotFormatsConverter.CreateOpenXmlElement<DXDC.PivotFormats>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   3D view settings.
  /// </summary>
  [DataMember]
  public DMDC.View3D? View3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.View3D>();
      if (element != null)
        return View3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.View3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = View3DConverter.CreateOpenXmlElement<DXDC.View3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   3D floor formatting.
  /// </summary>
  [DataMember]
  public DMDC.Floor? Floor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Floor>();
      if (element != null)
        return FloorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Floor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FloorConverter.CreateOpenXmlElement<DXDC.Floor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   3D side wall formatting.
  /// </summary>
  [DataMember]
  public DMDC.SideWall? SideWall
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.SideWall>();
      if (element != null)
        return SideWallConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SideWall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SideWallConverter.CreateOpenXmlElement<DXDC.SideWall>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   3D back wall formatting.
  /// </summary>
  [DataMember]
  public DMDC.BackWall? BackWall
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.BackWall>();
      if (element != null)
        return BackWallConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BackWall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackWallConverter.CreateOpenXmlElement<DXDC.BackWall>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Plot data and formatting.
  /// </summary>
  [DataMember]
  public DMDC.PlotArea? PlotArea
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PlotArea>();
      if (element != null)
        return PlotAreaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaConverter.CreateOpenXmlElement<DXDC.PlotArea>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Legend data and formatting.
  /// </summary>
  [DataMember]
  public DMDC.Legend? Legend
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Legend>();
      if (element != null)
        return LegendConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Legend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegendConverter.CreateOpenXmlElement<DXDC.Legend>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   True if only visible cells are plotted..
  /// </summary>
  [DataMember]
  public DMDC.PlotVisibleOnly? PlotVisibleOnly
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PlotVisibleOnly>();
      if (element != null)
        return PlotVisibleOnlyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PlotVisibleOnly>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotVisibleOnlyConverter.CreateOpenXmlElement<DXDC.PlotVisibleOnly>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   The way that blank cells are plotted on a chart..
  /// </summary>
  [DataMember]
  public DMDC.DisplayBlanksAsKind? DisplayBlanksAs
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>(_ExistingElement.GetFirstChild<DXDC.DisplayBlanksAs>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DisplayBlanksAs>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>(itemElement, (DMDC.DisplayBlanksAsKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.DisplayBlanksAs, DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DMDC.DisplayBlanksAsKind>((DMDC.DisplayBlanksAsKind)value));
    }
  }
  
  
  /// <summary>
  ///   True if we should render datalabels over the maximum scale.
  /// </summary>
  [DataMember]
  public DMDC.ShowDataLabelsOverMaximum? ShowDataLabelsOverMaximum
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowDataLabelsOverMaximum>();
      if (element != null)
        return ShowDataLabelsOverMaximumConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowDataLabelsOverMaximum>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowDataLabelsOverMaximumConverter.CreateOpenXmlElement<DXDC.ShowDataLabelsOverMaximum>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Extensibility container.
  /// </summary>
  [DataMember]
  public DMDC.ChartExtensionList? ChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartExtensionList>();
      if (element != null)
        return ChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartExtensionListConverter.CreateOpenXmlElement<DXDC.ChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
