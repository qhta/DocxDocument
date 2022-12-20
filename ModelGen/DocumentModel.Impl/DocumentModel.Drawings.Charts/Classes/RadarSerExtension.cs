namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the RadarSerExtension Class.
/// </summary>
public partial class RadarSerExtensionImpl: ModelElementImpl, RadarSerExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public RadarSerExtensionImpl(): base() {}
  
  public RadarSerExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.RadarSerExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredSeriesTitle? FilteredSeriesTitle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredSeriesTitleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredSeriesTitleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.FilteredCategoryTitle? FilteredCategoryTitle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.FilteredCategoryTitleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.FilteredCategoryTitleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.DataLabelsRange? DataLabelsRange
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DataLabelsRangeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DataLabelsRangeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Charts.CategoryFilterExceptions? CategoryFilterExceptions
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.CategoryFilterExceptionsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.CategoryFilterExceptionsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
