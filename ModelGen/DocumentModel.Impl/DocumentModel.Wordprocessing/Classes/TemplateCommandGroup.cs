namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public class TemplateCommandGroupImpl: ModelElementImpl, TemplateCommandGroup
{
  public DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TemplateCommandGroupImpl(): base() {}
  
  public TemplateCommandGroupImpl(DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.KeyMapCustomizations>? KeyMapCustomizationses
  {
    get
    {
      if (_KeyMapCustomizationses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>()
            .Select(item => new DocumentModel.Wordprocessing.KeyMapCustomizationsImpl(item)).ToList();
          _KeyMapCustomizationses = new ObservableCollection<DocumentModel.Wordprocessing.KeyMapCustomizations>(items);
        }
        else
          _KeyMapCustomizationses = new ObservableCollection<DocumentModel.Wordprocessing.KeyMapCustomizations>();
        _KeyMapCustomizationses.CollectionChanged += _KeyMapCustomizationses_CollectionChanged;
      }
      return _KeyMapCustomizationses;
    }
    set
    {
      if (value != null && value != _KeyMapCustomizationses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.KeyMapCustomizationsImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.KeyMapCustomizations> observableCollection)
        _KeyMapCustomizationses = observableCollection;
      else if (value != null)
        _KeyMapCustomizationses = new ObservableCollection<DocumentModel.Wordprocessing.KeyMapCustomizations>(value);
      else
       _KeyMapCustomizationses = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.KeyMapCustomizations>? _KeyMapCustomizationses;
  
  private void _KeyMapCustomizationses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.KeyMapCustomizationsImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Wordprocessing.KeyMapCustomizationsImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.KeyMapCustomizations>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    oldItem.Remove();
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public Collection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>? MismatchedKeyMapCustomizations
  {
    get
    {
      if (_MismatchedKeyMapCustomizations != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>()
            .Select(item => new DocumentModel.Wordprocessing.MismatchedKeyMapCustomizationImpl(item)).ToList();
          _MismatchedKeyMapCustomizations = new ObservableCollection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>(items);
        }
        else
          _MismatchedKeyMapCustomizations = new ObservableCollection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>();
        _MismatchedKeyMapCustomizations.CollectionChanged += _MismatchedKeyMapCustomizations_CollectionChanged;
      }
      return _MismatchedKeyMapCustomizations;
    }
    set
    {
      if (value != null && value != _MismatchedKeyMapCustomizations && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.MismatchedKeyMapCustomizationImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization> observableCollection)
        _MismatchedKeyMapCustomizations = observableCollection;
      else if (value != null)
        _MismatchedKeyMapCustomizations = new ObservableCollection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>(value);
      else
       _MismatchedKeyMapCustomizations = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.MismatchedKeyMapCustomization>? _MismatchedKeyMapCustomizations;
  
  private void _MismatchedKeyMapCustomizations_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.MismatchedKeyMapCustomizationImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Wordprocessing.MismatchedKeyMapCustomizationImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.MismatchedKeyMapCustomization>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    oldItem.Remove();
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
  public DocumentModel.Wordprocessing.Toolbars? Toolbars
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ToolbarsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.Toolbars>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ToolbarsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.AllocatedCommands>? AllocatedCommandses
  {
    get
    {
      if (_AllocatedCommandses != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>()
            .Select(item => new DocumentModel.Wordprocessing.AllocatedCommandsImpl(item)).ToList();
          _AllocatedCommandses = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommands>(items);
        }
        else
          _AllocatedCommandses = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommands>();
        _AllocatedCommandses.CollectionChanged += _AllocatedCommandses_CollectionChanged;
      }
      return _AllocatedCommandses;
    }
    set
    {
      if (value != null && value != _AllocatedCommandses && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.AllocatedCommandsImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommands> observableCollection)
        _AllocatedCommandses = observableCollection;
      else if (value != null)
        _AllocatedCommandses = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommands>(value);
      else
       _AllocatedCommandses = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommands>? _AllocatedCommandses;
  
  private void _AllocatedCommandses_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.AllocatedCommandsImpl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Wordprocessing.AllocatedCommandsImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommands>()
                                .FirstOrDefault(anItem => anItem == valImpl.OpenXmlElement);
                 if (oldItem != null)
                    oldItem.Remove();
             };
          }
          break;
        default:
          break;
      }
    }
  }
  
  
}
