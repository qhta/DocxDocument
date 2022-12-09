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
  public Text2? Text
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties8? ShapeProperties
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
  
  public Collection<DataPoint1>? DataPoints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DataLabels2? DataLabels
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.UInt32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
  
  public ExtensionList2? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
