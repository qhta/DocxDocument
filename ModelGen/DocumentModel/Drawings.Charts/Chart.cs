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
      return _Element?.GetObject<DMDC.Title,DXDC.Title>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Title,DXDC.Title>(value);
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
      return _Element?.GetObject<DMDC.AutoTitleDeleted,DXDC.AutoTitleDeleted>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.AutoTitleDeleted,DXDC.AutoTitleDeleted>(value);
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
      return _Element?.GetObject<DMDC.PivotFormats,DXDC.PivotFormats>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PivotFormats,DXDC.PivotFormats>(value);
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
      return _Element?.GetObject<DMDC.View3D,DXDC.View3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.View3D,DXDC.View3D>(value);
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
      return _Element?.GetObject<DMDC.Floor,DXDC.Floor>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Floor,DXDC.Floor>(value);
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
      return _Element?.GetObject<DMDC.SideWall,DXDC.SideWall>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.SideWall,DXDC.SideWall>(value);
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
      return _Element?.GetObject<DMDC.BackWall,DXDC.BackWall>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BackWall,DXDC.BackWall>(value);
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
      return _Element?.GetObject<DMDC.PlotArea,DXDC.PlotArea>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PlotArea,DXDC.PlotArea>(value);
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
      return _Element?.GetObject<DMDC.Legend,DXDC.Legend>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Legend,DXDC.Legend>(value);
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
      return _Element?.GetObject<DMDC.PlotVisibleOnly,DXDC.PlotVisibleOnly>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PlotVisibleOnly,DXDC.PlotVisibleOnly>(value);
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
      return _Element?.GetObject<DMDC.ShowDataLabelsOverMaximum,DXDC.ShowDataLabelsOverMaximum>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowDataLabelsOverMaximum,DXDC.ShowDataLabelsOverMaximum>(value);
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
      return _Element?.GetObject<DMDC.ChartExtensionList,DXDC.ChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartExtensionList,DXDC.ChartExtensionList>(value);
    }
  }
  
}
