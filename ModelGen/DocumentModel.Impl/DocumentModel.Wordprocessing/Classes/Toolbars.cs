namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Toolbars Class.
/// </summary>
public class ToolbarsImpl: ModelElementImpl, Toolbars
{
  public DocumentFormat.OpenXml.Office.Word.Toolbars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.Toolbars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ToolbarsImpl(): base() {}
  
  public ToolbarsImpl(DocumentFormat.OpenXml.Office.Word.Toolbars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Wordprocessing.AllocatedCommandManifest>? AllocatedCommandManifests
  {
    get
    {
      if (_AllocatedCommandManifests != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>()
            .Select(item => new DocumentModel.Wordprocessing.AllocatedCommandManifestImpl(item)).ToList();
          _AllocatedCommandManifests = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommandManifest>(items);
        }
        else
          _AllocatedCommandManifests = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommandManifest>();
        _AllocatedCommandManifests.CollectionChanged += _AllocatedCommandManifests_CollectionChanged;
      }
      return _AllocatedCommandManifests;
    }
    set
    {
      if (value != null && value != _AllocatedCommandManifests && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.AllocatedCommandManifestImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommandManifest> observableCollection)
        _AllocatedCommandManifests = observableCollection;
      else if (value != null)
        _AllocatedCommandManifests = new ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommandManifest>(value);
      else
       _AllocatedCommandManifests = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.AllocatedCommandManifest>? _AllocatedCommandManifests;
  
  private void _AllocatedCommandManifests_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.AllocatedCommandManifestImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.AllocatedCommandManifestImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.AllocatedCommandManifest>()
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
  
  
  public Collection<DocumentModel.Wordprocessing.ToolbarData>? ToolbarDatas
  {
    get
    {
      if (_ToolbarDatas != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.ToolbarData>()
            .Select(item => new DocumentModel.Wordprocessing.ToolbarDataImpl(item)).ToList();
          _ToolbarDatas = new ObservableCollection<DocumentModel.Wordprocessing.ToolbarData>(items);
        }
        else
          _ToolbarDatas = new ObservableCollection<DocumentModel.Wordprocessing.ToolbarData>();
        _ToolbarDatas.CollectionChanged += _ToolbarDatas_CollectionChanged;
      }
      return _ToolbarDatas;
    }
    set
    {
      if (value != null && value != _ToolbarDatas && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.ToolbarData>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.ToolbarDataImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.ToolbarData> observableCollection)
        _ToolbarDatas = observableCollection;
      else if (value != null)
        _ToolbarDatas = new ObservableCollection<DocumentModel.Wordprocessing.ToolbarData>(value);
      else
       _ToolbarDatas = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.ToolbarData>? _ToolbarDatas;
  
  private void _ToolbarDatas_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.Word.ToolbarData>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.ToolbarDataImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.ToolbarDataImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.Word.ToolbarData>()
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
