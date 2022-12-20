namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public partial class TrendlineImpl: ModelElementImpl, Trendline
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.Trendline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Trendline?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TrendlineImpl(): base() {}
  
  public TrendlineImpl(DocumentFormat.OpenXml.Drawing.Charts.Trendline openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Trendline Name.
  /// </summary>
  public String? TrendlineName
  {
    get => (System.String?)OpenXmlElement?.TrendlineName?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TrendlineName != null)
        {
          if (value is not null)
            OpenXmlElement.TrendlineName.Text = value;
          else
            OpenXmlElement.TrendlineName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TrendlineName = new DocumentFormat.OpenXml.Drawing.Charts.TrendlineName{ Text = value };
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
  /// Trendline Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineKind? TrendlineType
  {
    get => (DocumentModel.Drawings.Charts.TrendlineKind?)OpenXmlElement?.TrendlineType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.TrendlineType != null)
        {
          if (value is not null)
            OpenXmlElement.TrendlineType.Val = (DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues?)value;
          else
            OpenXmlElement.TrendlineType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.TrendlineType = new DocumentFormat.OpenXml.Drawing.Charts.TrendlineType{ Val = (DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  public Byte? PolynomialOrder
  {
    get => (System.Byte?)OpenXmlElement?.PolynomialOrder?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PolynomialOrder != null)
        {
          if (value is not null)
            OpenXmlElement.PolynomialOrder.Val = (System.Byte?)value;
          else
            OpenXmlElement.PolynomialOrder = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PolynomialOrder = new DocumentFormat.OpenXml.Drawing.Charts.PolynomialOrder{ Val = (System.Byte?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Period.
  /// </summary>
  public UInt32? Period
  {
    get => (System.UInt32?)OpenXmlElement?.Period?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Period != null)
        {
          if (value is not null)
            OpenXmlElement.Period.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Period = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Period = new DocumentFormat.OpenXml.Drawing.Charts.Period{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public Double? Forward
  {
    get => (System.Double?)OpenXmlElement?.Forward?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Forward != null)
        {
          if (value is not null)
            OpenXmlElement.Forward.Val = (System.Double?)value;
          else
            OpenXmlElement.Forward = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Forward = new DocumentFormat.OpenXml.Drawing.Charts.Forward{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public Double? Backward
  {
    get => (System.Double?)OpenXmlElement?.Backward?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Backward != null)
        {
          if (value is not null)
            OpenXmlElement.Backward.Val = (System.Double?)value;
          else
            OpenXmlElement.Backward = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Backward = new DocumentFormat.OpenXml.Drawing.Charts.Backward{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public Double? Intercept
  {
    get => (System.Double?)OpenXmlElement?.Intercept?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Intercept != null)
        {
          if (value is not null)
            OpenXmlElement.Intercept.Val = (System.Double?)value;
          else
            OpenXmlElement.Intercept = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Intercept = new DocumentFormat.OpenXml.Drawing.Charts.Intercept{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public Boolean? DisplayRSquaredValue
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.DisplayRSquaredValue();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public Boolean? DisplayEquation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.DisplayEquation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineLabel? TrendlineLabel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.TrendlineLabelImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.TrendlineLabelImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
