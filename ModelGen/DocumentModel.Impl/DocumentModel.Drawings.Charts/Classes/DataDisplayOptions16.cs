namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataDisplayOptions16 Class.
/// </summary>
public partial class DataDisplayOptions16Impl: ModelElementImpl, DataDisplayOptions16
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DataDisplayOptions16Impl(): base() {}
  
  public DataDisplayOptions16Impl(DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16 openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// BooleanFalse.
  /// </summary>
  public Boolean? BooleanFalse
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
