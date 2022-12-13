namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Value Axis.
/// </summary>
public class ValueAxisImpl: ModelElementImpl, ValueAxis
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValueAxis?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValueAxisImpl(): base() {}
  
  public ValueAxisImpl(DocumentFormat.OpenXml.Drawing.Charts.ValueAxis openXmlElement): base(openXmlElement)
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public DocumentModel.Drawings.Charts.MinorGridlines? MinorGridlines
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Title.
  /// </summary>
  public DocumentModel.Drawings.Charts.Title? Title
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
        return (DocumentModel.Drawings.Charts.CrossesKind?)openXmlElement?.Val?.Value;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossesAt>();
        return (System.Double?)openXmlElement?.Val?.Value;
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
  
  public DocumentModel.Drawings.Charts.CrossBetweenKind? CrossBetween
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween>();
        return (DocumentModel.Drawings.Charts.CrossBetweenKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.CrossBetween{ Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues?)value };
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorUnit>();
        return (System.Double?)openXmlElement?.Val?.Value;
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
  
  public Double? MinorUnit
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorUnit>();
        return (System.Double?)openXmlElement?.Val?.Value;
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
  
  public DocumentModel.Drawings.Charts.DisplayUnits? DisplayUnits
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.Charts.ValAxExtensionList? ValAxExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
