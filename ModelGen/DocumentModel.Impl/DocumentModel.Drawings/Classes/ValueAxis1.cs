namespace DocumentModel.Drawings;

/// <summary>
/// Value Axis.
/// </summary>
public class ValueAxis1Impl: ModelElementImpl, ValueAxis1
{
  public DocumentFormat.OpenXml.Drawing.Charts.ValueAxis? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ValueAxis?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Axis ID.
  /// </summary>
  public UInt32? AxisId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Scaling.
  /// </summary>
  public Scaling? Scaling
  {
    get;
    set;
  }
  
  /// <summary>
  /// Delete.
  /// </summary>
  public Boolean? Delete
  {
    get;
    set;
  }
  
  /// <summary>
  /// Axis Position.
  /// </summary>
  public AxisPositionKind? AxisPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisPosition>();
        return (AxisPositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AxisPosition>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.AxisPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Major Gridlines.
  /// </summary>
  public MajorGridlines? MajorGridlines
  {
    get;
    set;
  }
  
  /// <summary>
  /// Minor Gridlines.
  /// </summary>
  public MinorGridlines? MinorGridlines
  {
    get;
    set;
  }
  
  /// <summary>
  /// Title.
  /// </summary>
  public Title1? Title
  {
    get;
    set;
  }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public NumberingFormat1? NumberingFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// Major Tick Mark.
  /// </summary>
  public TickMarkKind? MajorTickMark
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark>();
        return (TickMarkKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.MajorTickMark{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Minor Tick Mark.
  /// </summary>
  public TickMarkKind? MinorTickMark
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark>();
        return (TickMarkKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.MinorTickMark{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Tick Label Position.
  /// </summary>
  public TickLabelPositionKind? TickLabelPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition>();
        return (TickLabelPositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.TickLabelPosition{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties2? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Crossing Axis ID.
  /// </summary>
  public UInt32? CrossingAxis
  {
    get;
    set;
  }
  
  public CrossesKind? Crosses
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
        return (CrossesKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Crosses>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossesValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Crosses{ Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossesValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Double? CrossesAt
  {
    get;
    set;
  }
  
  public CrossBetweenKind? CrossBetween
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween>();
        return (CrossBetweenKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CrossBetween>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.CrossBetween{ Val = (DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Double? MajorUnit
  {
    get;
    set;
  }
  
  public Double? MinorUnit
  {
    get;
    set;
  }
  
  public DisplayUnits? DisplayUnits
  {
    get;
    set;
  }
  
  public ValAxExtensionList? ValAxExtensionList
  {
    get;
    set;
  }
  
}
