namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public class DataLabelImpl: ModelElementImpl, DataLabel
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  public DocumentModel.Drawings16.Charts.DataLabelPos? Pos
  {
    get => (DocumentModel.Drawings16.Charts.DataLabelPos?)OpenXmlElement?.Pos?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pos = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos?)value;
    }
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  public DocumentModel.Drawings16.Charts.NumberFormat? NumberFormat
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  public DocumentModel.Drawings16.Charts.DataLabelVisibilities? DataLabelVisibilities
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
