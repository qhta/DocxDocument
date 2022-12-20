namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Surface Chart Series.
/// </summary>
public partial class SurfaceChartSeriesImpl: ModelElementImpl, SurfaceChartSeries
{
  public DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SurfaceChartSeriesImpl(): base() {}
  
  public SurfaceChartSeriesImpl(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Index != null)
        {
          if (value is not null)
            OpenXmlElement.Index.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Index = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Index = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Order.
  /// </summary>
  public UInt32? Order
  {
    get => (System.UInt32?)OpenXmlElement?.Order?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Order != null)
        {
          if (value is not null)
            OpenXmlElement.Order.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Order = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Order = new DocumentFormat.OpenXml.Drawing.Charts.Order{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Series Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.SeriesText? SeriesText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.SeriesTextImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.SeriesTextImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
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
  /// PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.PictureOptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureOptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.PictureOptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// CategoryAxisData.
  /// </summary>
  public DocumentModel.Drawings.Charts.CategoryAxisData? CategoryAxisData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.CategoryAxisDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.CategoryAxisDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Values.
  /// </summary>
  public DocumentModel.Drawings.Charts.Values? Values
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ValuesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Values>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ValuesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Bubble3D>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Bubble3D();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// SurfaceSerExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.SurfaceSerExtensionList? SurfaceSerExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.SurfaceSerExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.SurfaceSerExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
