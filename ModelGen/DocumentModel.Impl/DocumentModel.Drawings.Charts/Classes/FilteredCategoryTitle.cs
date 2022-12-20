namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the FilteredCategoryTitle Class.
/// </summary>
public partial class FilteredCategoryTitleImpl: ModelElementImpl, FilteredCategoryTitle
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FilteredCategoryTitleImpl(): base() {}
  
  public FilteredCategoryTitleImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// AxisDataSourceType.
  /// </summary>
  public DocumentModel.Drawings.Charts.AxisDataSourceType3? AxisDataSourceType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.AxisDataSourceType3Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.AxisDataSourceType3Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
