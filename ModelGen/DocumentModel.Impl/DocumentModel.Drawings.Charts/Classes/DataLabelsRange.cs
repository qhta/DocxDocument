namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public partial class DataLabelsRangeImpl: ModelElementImpl, DataLabelsRange
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DataLabelsRangeImpl(): base() {}
  
  public DataLabelsRangeImpl(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get => (System.String?)OpenXmlElement?.Formula?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Formula != null)
        {
          if (value is not null)
            OpenXmlElement.Formula.Text = value;
          else
            OpenXmlElement.Formula = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Formula = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.Formula{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabelsRangeChache? DataLabelsRangeChache
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.DataLabelsRangeChacheImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRangeChache>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.DataLabelsRangeChacheImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
