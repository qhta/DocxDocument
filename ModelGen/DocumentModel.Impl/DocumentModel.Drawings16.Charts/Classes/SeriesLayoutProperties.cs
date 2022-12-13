namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public class SeriesLayoutPropertiesImpl: ModelElementImpl, SeriesLayoutProperties
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SeriesLayoutPropertiesImpl(): base() {}
  
  public SeriesLayoutPropertiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ParentLabelLayout? ParentLabelLayout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public DocumentModel.Drawings16.Charts.RegionLabelLayoutEnum? RegionLabelLayout
  {
    get => (DocumentModel.Drawings16.Charts.RegionLabelLayoutEnum?)OpenXmlElement?.RegionLabelLayout?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RegionLabelLayout != null)
        {
          if (value is not null)
            OpenXmlElement.RegionLabelLayout.Val = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum?)value;
          else
            OpenXmlElement.RegionLabelLayout = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RegionLabelLayout = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout{ Val = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public DocumentModel.Drawings16.Charts.SeriesElementVisibilities? SeriesElementVisibilities
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? Aggregation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings16.Charts.Binning? Binning
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.Geography? Geography
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.Statistics? Statistics
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.Subtotals? Subtotals
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
