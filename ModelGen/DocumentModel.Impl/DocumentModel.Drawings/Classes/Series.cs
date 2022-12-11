namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public class SeriesImpl: ModelElementImpl, Series
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SeriesImpl(): base() {}
  
  public SeriesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public SeriesLayout? LayoutId
  {
    get => (SeriesLayout?)OpenXmlElement?.LayoutId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LayoutId = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout?)value;
    }
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Hidden
  {
    get => (Boolean?)OpenXmlElement?.Hidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? OwnerIdx
  {
    get => (UInt32?)OpenXmlElement?.OwnerIdx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OwnerIdx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? UniqueId
  {
    get => (String?)OpenXmlElement?.UniqueId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UniqueId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? FormatIdx
  {
    get => (UInt32?)OpenXmlElement?.FormatIdx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatIdx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public Text? Text
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public ValueColors? ValueColors
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public ValueColorPositions? ValueColorPositions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DataPoint>? DataPoints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DataLabels? DataLabels
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public UInt32? DataId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public SeriesLayoutProperties? SeriesLayoutProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<String>? AxisIds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
