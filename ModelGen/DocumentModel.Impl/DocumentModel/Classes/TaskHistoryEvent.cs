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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.TaskAnchor? TaskAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.OpenXmlTaskUserElement? AssignTaskUser
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.OpenXmlTaskUserElement? UnassignTaskUser
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.TaskScheduleEventInfo? TaskScheduleEventInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.TaskProgressEventInfo? TaskProgressEventInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.TaskPriorityEventInfo? TaskPriorityEventInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
