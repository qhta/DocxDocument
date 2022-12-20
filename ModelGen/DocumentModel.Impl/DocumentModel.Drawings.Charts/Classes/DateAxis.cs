namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Date Axis.
/// </summary>
public partial class DateAxisImpl: ModelElementImpl, DateAxis
{
  public DocumentFormat.OpenXml.Drawing.Charts.DateAxis? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DateAxis?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DateAxisImpl(): base() {}
  
  public DateAxisImpl(DocumentFormat.OpenXml.Drawing.Charts.DateAxis openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Axis ID.
  /// </summary>
  public UInt32? AxisId
  {
    get => (System.UInt32?)OpenXmlElement?.AxisId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AxisId != null)
        {
          if (value is not null)
            OpenXmlElement.AxisId.Val = (System.UInt32?)value;
          else
            OpenXmlElement.AxisId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AxisId = new DocumentFormat.OpenXml.Drawing.Charts.AxisId{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public DocumentModel.Drawings.Charts.Scaling? Scaling
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ScalingImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ScalingImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public Boolean? Delete
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Delete>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Delete();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.AxisPositionKind? AxisPosition
  {
    get => (DocumentModel.Drawings.Charts.AxisPositionKind?)OpenXmlElement?.AxisPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AxisPosition != null)
        {
          if (value is not null)
            OpenXmlElement.AxisPosition.Val = (DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues?)value;
          else
            OpenXmlElement.AxisPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AxisPosition = new DocumentFormat.OpenXml.Drawing.Charts.AxisPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MajorGridlines? MajorGridlines
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.MajorGridlinesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.MajorGridlinesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MinorGridlines? MinorGridlines
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.MinorGridlinesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.MinorGridlinesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Title.
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
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.NumberingFormatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.NumberingFormatImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickMarkKind? MajorTickMark
  {
    get => (DocumentModel.Drawings.Charts.TickMarkKind?)OpenXmlElement?.MajorTickMark?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MajorTickMark != null)
        {
          if (value is not null)
            OpenXmlElement.MajorTickMark.Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value;
          else
            OpenXmlElement.MajorTickMark = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MajorTickMark = new DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickMarkKind? MinorTickMark
  {
    get => (DocumentModel.Drawings.Charts.TickMarkKind?)OpenXmlElement?.MinorTickMark?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MinorTickMark != null)
        {
          if (value is not null)
            OpenXmlElement.MinorTickMark.Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value;
          else
            OpenXmlElement.MinorTickMark = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MinorTickMark = new DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public DocumentModel.Drawings.Charts.TickLabelPositionKind? TickLabelPosition
  {
    get => (DocumentModel.Drawings.Charts.TickLabelPositionKind?)OpenXmlElement?.TickLabelPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TickLabelPosition != null)
        {
          if (value is not null)
            OpenXmlElement.TickLabelPosition.Val = (DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues?)value;
          else
            OpenXmlElement.TickLabelPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TickLabelPosition = new DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ChartShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ChartShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.TextPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.TextPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public UInt32? CrossingAxis
  {
    get => (System.UInt32?)OpenXmlElement?.CrossingAxis?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.CrossingAxis != null)
        {
          if (value is not null)
            OpenXmlElement.CrossingAxis.Val = (System.UInt32?)value;
          else
            OpenXmlElement.CrossingAxis = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.CrossingAxis = new DocumentFormat.OpenXml.Drawing.Charts.CrossingAxis{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.CrossesKind? Crosses
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
        return (DocumentModel.Drawings.Charts.CrossesKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossesValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Crosses{ Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossesValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Double? CrossesAt
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossesAt>();
        return (System.Double?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossesAt>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.CrossesAt{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? AutoLabeled
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.AutoLabeled{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public UInt16? LabelOffset
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LabelOffset>();
        return (System.UInt16?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LabelOffset>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt16?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.LabelOffset{ Val = (System.UInt16?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.TimeUnitKind? BaseTimeUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit>();
        return (DocumentModel.Drawings.Charts.TimeUnitKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.BaseTimeUnit{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Double? MajorUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorUnit>();
        return (System.Double?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.MajorUnit{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.TimeUnitKind? MajorTimeUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit>();
        return (DocumentModel.Drawings.Charts.TimeUnitKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.MajorTimeUnit{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Double? MinorUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorUnit>();
        return (System.Double?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.MinorUnit{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.TimeUnitKind? MinorTimeUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit>();
        return (DocumentModel.Drawings.Charts.TimeUnitKind?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.MinorTimeUnit{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TimeUnitValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.DateAxExtensionList? DateAxExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DateAxExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DateAxExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
