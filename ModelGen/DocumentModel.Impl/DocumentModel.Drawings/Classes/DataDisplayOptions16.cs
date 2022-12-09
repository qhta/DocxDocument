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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Boolean?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
