namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataModelExtension Class.
/// </summary>
public partial class DataModelExtensionImpl: ModelElementImpl, DataModelExtension
{
  public DocumentFormat.OpenXml.Drawing.DataModelExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.DataModelExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DataModelExtensionImpl(): base() {}
  
  public DataModelExtensionImpl(DocumentFormat.OpenXml.Drawing.DataModelExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.Office.DataModelExtensionBlock? DataModelExtensionBlock
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
        if (item != null)
          return new DocumentModel.Drawings.Office.DataModelExtensionBlockImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.DataModelExtensionBlock>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.DataModelExtensionBlockImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? RecolorImages
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages>();
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
            item = new DocumentFormat.OpenXml.Office2010.Drawing.Diagram.RecolorImages{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
