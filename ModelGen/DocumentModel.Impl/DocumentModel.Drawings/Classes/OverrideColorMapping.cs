namespace DocumentModel.Drawings;

/// <summary>
/// Override Color Mapping.
/// </summary>
public class OverrideColorMappingImpl: DocumentModel.Drawings.ColorMappingTypeImpl, OverrideColorMapping
{
  public new DocumentFormat.OpenXml.Drawing.OverrideColorMapping? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OverrideColorMapping?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OverrideColorMappingImpl(): base() {}
  
  public OverrideColorMappingImpl(DocumentFormat.OpenXml.Drawing.OverrideColorMapping openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
