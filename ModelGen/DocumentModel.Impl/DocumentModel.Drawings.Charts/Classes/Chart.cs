namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public class ChartImpl: ModelElementImpl, Chart
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public DocumentModel.Drawings.Charts.View3D? View3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.Floor? Floor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.SideWall? SideWall
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.BackWall? BackWall
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.PlotArea? PlotArea
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.Legend? Legend
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
