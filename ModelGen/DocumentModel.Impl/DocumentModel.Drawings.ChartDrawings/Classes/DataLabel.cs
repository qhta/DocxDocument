namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public partial class DataLabelImpl: ModelElementImpl, DataLabel
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DataLabelImpl(): base() {}
  
  public DataLabelImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get => (System.UInt32?)OpenXmlElement?.Idx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Idx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelPos? Pos
  {
    get => (DocumentModel.Drawings.ChartDrawings.DataLabelPos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos?)value;
    }
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NumberFormat? NumberFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.NumberFormatImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.NumberFormatImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.TxPrTextBody? TxPrTextBody
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.TxPrTextBodyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.TxPrTextBodyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.DataLabelVisibilities? DataLabelVisibilities
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.DataLabelVisibilitiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelVisibilities>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.DataLabelVisibilitiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  public String? SeparatorXsdstring
  {
    get => (System.String?)OpenXmlElement?.SeparatorXsdstring?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SeparatorXsdstring != null)
        {
          if (value is not null)
            OpenXmlElement.SeparatorXsdstring.Text = value;
          else
            OpenXmlElement.SeparatorXsdstring = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SeparatorXsdstring = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeparatorXsdstring{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ChartDrawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ChartDrawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
