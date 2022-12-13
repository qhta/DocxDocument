namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public class DataLabelsRangeImpl: ModelElementImpl, DataLabelsRange
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  public DocumentModel.Drawings13.Charts.DataLabelsRangeChache? DataLabelsRangeChache
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
