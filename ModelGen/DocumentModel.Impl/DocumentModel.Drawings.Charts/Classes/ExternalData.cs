namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public partial class ExternalDataImpl: ModelElementImpl, ExternalData
{
  public DocumentFormat.OpenXml.Drawing.Charts.ExternalData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ExternalData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExternalDataImpl(): base() {}
  
  public ExternalDataImpl(DocumentFormat.OpenXml.Drawing.Charts.ExternalData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.AutoUpdate();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
