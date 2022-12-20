namespace DocumentModel;

/// <summary>
/// Defines the BackstageGroups Class.
/// </summary>
public partial class BackstageGroupsImpl: ModelElementImpl, BackstageGroups
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackstageGroupsImpl(): base() {}
  
  public BackstageGroupsImpl(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.TaskFormGroup? TaskFormGroup
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
        if (item != null)
          return new DocumentModel.TaskFormGroupImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskFormGroupImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
