namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataDisplayOptions16 Class.
/// </summary>
public class DataDisplayOptions16Impl: ModelElementImpl, DataDisplayOptions16
{
  public DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
