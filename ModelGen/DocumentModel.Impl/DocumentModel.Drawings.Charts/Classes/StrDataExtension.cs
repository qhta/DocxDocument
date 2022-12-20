namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public partial class StrDataExtensionImpl: ModelElementImpl, StrDataExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StrDataExtensionImpl(): base() {}
  
  public StrDataExtensionImpl(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtension openXmlElement): base(openXmlElement)
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
  
  public Boolean? AutoGeneneratedCategories
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories>();
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
            item = new DocumentFormat.OpenXml.Office2013.Drawing.Chart.AutoGeneneratedCategories{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
