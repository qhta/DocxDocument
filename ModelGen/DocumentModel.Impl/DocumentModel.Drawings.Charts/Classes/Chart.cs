namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public partial class ChartImpl: ModelElementImpl, Chart
{
  public DocumentFormat.OpenXml.Drawing.Charts.Chart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Chart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ChartImpl(): base() {}
  
  public ChartImpl(DocumentFormat.OpenXml.Drawing.Charts.Chart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.Title? Title
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.TitleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.TitleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  public Boolean? AutoTitleDeleted
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public DocumentModel.Drawings.Charts.PivotFormats? PivotFormats
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PivotFormatsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PivotFormatsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public DocumentModel.Drawings.Charts.View3D? View3D
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.View3D>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.View3DImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.View3D>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.View3DImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.Floor? Floor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Floor>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FloorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Floor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FloorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.SideWall? SideWall
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SideWall>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.SideWallImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SideWall>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.SideWallImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.BackWall? BackWall
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BackWall>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.BackWallImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BackWall>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.BackWallImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.PlotArea? PlotArea
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PlotAreaImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PlotAreaImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.Legend? Legend
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Legend>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.LegendImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Legend>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.LegendImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  public Boolean? PlotVisibleOnly
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public DocumentModel.Drawings.Charts.DisplayBlanksAsKind? DisplayBlanksAs
  {
    get => (DocumentModel.Drawings.Charts.DisplayBlanksAsKind?)OpenXmlElement?.DisplayBlanksAs?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DisplayBlanksAs != null)
        {
          if (value is not null)
            OpenXmlElement.DisplayBlanksAs.Val = (DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues?)value;
          else
            OpenXmlElement.DisplayBlanksAs = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DisplayBlanksAs = new DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs{ Val = (DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  public Boolean? ShowDataLabelsOverMaximum
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartExtensionList? ChartExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
