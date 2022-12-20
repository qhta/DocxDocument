namespace DocumentModel.Math;

/// <summary>
/// Matrix Columns.
/// </summary>
public partial class MatrixColumnsImpl: ModelElementImpl, MatrixColumns
{
  public DocumentFormat.OpenXml.Math.MatrixColumns? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixColumns?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MatrixColumnsImpl(): base() {}
  
  public MatrixColumnsImpl(DocumentFormat.OpenXml.Math.MatrixColumns openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Math.MatrixColumn>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixColumn>()
            .Select(item => new DocumentModel.Math.MatrixColumnImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Math.MatrixColumn>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Math.MatrixColumn>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixColumn>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Math.MatrixColumnImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Math.MatrixColumn> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Math.MatrixColumn>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Math.MatrixColumn>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixColumn>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Math.MatrixColumnImpl valImpl)
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
              if (val is DocumentModel.Math.MatrixColumnImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixColumn>()
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
