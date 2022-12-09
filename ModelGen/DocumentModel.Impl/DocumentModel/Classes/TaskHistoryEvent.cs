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
  
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time
  {
    get => (DateTime?)OpenXmlElement?.Time?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// AttributionTaskUser.
  /// </summary>
  public OpenXmlTaskUserElement? AttributionTaskUser
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OpenXmlTaskUserElement? AssignTaskUser
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public OpenXmlTaskUserElement? UnassignTaskUser
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public TaskTitleEventInfo? TaskTitleEventInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TaskScheduleEventInfo? TaskScheduleEventInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TaskProgressEventInfo? TaskProgressEventInfo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public TaskPriorityEventInfo? TaskPriorityEventInfo
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo();
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo();
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
        return openXmlElement != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
        if (openXmlElement != null)
        {
          if (value == false)
            openXmlElement.Remove();
        }
        else
        {
          if (value == true)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll();
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public TaskUndo? TaskUndo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
