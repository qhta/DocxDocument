namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Choose Element.
/// </summary>
public partial class ChooseImpl: ModelElementImpl, Choose
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.Choose? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Choose?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ChooseImpl(): base() {}
  
  public ChooseImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Choose openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.Diagrams.DiagramChooseIf? DiagramChooseIf
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.DiagramChooseIfImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.DiagramChooseIfImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.DiagramChooseElse? DiagramChooseElse
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.DiagramChooseElseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseElse>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.DiagramChooseElseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
