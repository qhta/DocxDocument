namespace DocumentModel;

/// <summary>
/// Defines the SimpleGroups Class.
/// </summary>
public partial class SimpleGroupsImpl: ModelElementImpl, SimpleGroups
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SimpleGroupsImpl(): base() {}
  
  public SimpleGroupsImpl(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.BackstageGroup? BackstageGroup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
        if (item != null)
          return new DocumentModel.BackstageGroupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.BackstageGroupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.TaskGroup? TaskGroup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
        if (item != null)
          return new DocumentModel.TaskGroupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskGroupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
