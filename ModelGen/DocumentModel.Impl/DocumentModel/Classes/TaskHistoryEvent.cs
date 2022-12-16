namespace DocumentModel;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public class TaskHistoryEventImpl: ModelElementImpl, TaskHistoryEvent
{
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TaskHistoryEventImpl(): base() {}
  
  public TaskHistoryEventImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time
  {
    get => (System.DateTime?)OpenXmlElement?.Time?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Time = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
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
  /// AttributionTaskUser.
  /// </summary>
  public DocumentModel.OpenXmlTaskUserElement? AttributionTaskUser
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement>();
        if (item != null)
          return new DocumentModel.OpenXmlTaskUserElementImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.OpenXmlTaskUserElementImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.TaskAnchor? TaskAnchor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
        if (item != null)
          return new DocumentModel.TaskAnchorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskAnchorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.OpenXmlTaskUserElement? AssignTaskUser
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement>();
        if (item != null)
          return new DocumentModel.OpenXmlTaskUserElementImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.OpenXmlTaskUserElementImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.OpenXmlTaskUserElement? UnassignTaskUser
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement>();
        if (item != null)
          return new DocumentModel.OpenXmlTaskUserElementImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.OpenXmlTaskUserElement>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.OpenXmlTaskUserElementImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? TaskCreateEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.TaskTitleEventInfo? TaskTitleEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
        if (item != null)
          return new DocumentModel.TaskTitleEventInfoImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskTitleEventInfoImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.TaskScheduleEventInfo? TaskScheduleEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
        if (item != null)
          return new DocumentModel.TaskScheduleEventInfoImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskScheduleEventInfoImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.TaskProgressEventInfo? TaskProgressEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
        if (item != null)
          return new DocumentModel.TaskProgressEventInfoImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskProgressEventInfoImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.TaskPriorityEventInfo? TaskPriorityEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
        if (item != null)
          return new DocumentModel.TaskPriorityEventInfoImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskPriorityEventInfoImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? TaskDeleteEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? TaskUndeleteEventInfo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? TaskUnassignAll
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.TaskUndo? TaskUndo
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
        if (item != null)
          return new DocumentModel.TaskUndoImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.TaskUndoImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
        if (item != null)
          return new DocumentModel.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
