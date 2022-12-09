namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public class ExternalData2Impl: ModelElementImpl, ExternalData2
{
  public DocumentFormat.OpenXml.Drawing.Charts.ExternalData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ExternalData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  public Boolean? AutoUpdate
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate>();
        return (Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate>();
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
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
