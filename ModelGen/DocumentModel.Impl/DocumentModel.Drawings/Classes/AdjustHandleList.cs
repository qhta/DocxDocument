namespace DocumentModel.Drawings;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
public partial class AdjustHandleListImpl: ModelElementImpl, AdjustHandleList
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.AdjustHandleList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustHandleList?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public AdjustHandleListImpl(): base() {}
  
  public AdjustHandleListImpl(DocumentFormat.OpenXml.Drawing.AdjustHandleList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Drawings.AdjustHandleXY? AdjustHandleXY
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustHandleXYImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandleXY>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustHandleXYImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.AdjustHandlePolar? AdjustHandlePolar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustHandlePolarImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustHandlePolar>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustHandlePolarImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
