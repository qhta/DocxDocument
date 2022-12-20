namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ExtensionList Class.
/// </summary>
public partial class ExtensionListImpl: ModelElementImpl, ExtensionList
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtensionListImpl(): base() {}
  
  public ExtensionListImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ChartDrawings.Extension2>? Extension2s
  {
    get
    {
      if (_Extension2s != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>()
            .Select(item => new DocumentModel.Drawings.ChartDrawings.Extension2Impl(item)).ToList();
          _Extension2s = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.Extension2>(items);
        }
        else
          _Extension2s = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.Extension2>();
        _Extension2s.CollectionChanged += _Extension2s_CollectionChanged;
      }
      return _Extension2s;
    }
    set
    {
      if (value != null && value != _Extension2s && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ChartDrawings.Extension2Impl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ChartDrawings.Extension2> observableCollection)
        _Extension2s = observableCollection;
      else if (value != null)
        _Extension2s = new ObservableCollection<DocumentModel.Drawings.ChartDrawings.Extension2>(value);
      else
       _Extension2s = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ChartDrawings.Extension2>? _Extension2s;
  
  private void _Extension2s_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ChartDrawings.Extension2Impl valImpl)
            {
              var item = valImpl.OpenXmlElement;
              if (item != null)
                OpenXmlElement.AddChild(item);
            };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
              if (val is DocumentModel.Drawings.ChartDrawings.Extension2Impl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2>()
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
