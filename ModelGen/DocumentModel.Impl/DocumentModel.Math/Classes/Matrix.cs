namespace DocumentModel.Math;

/// <summary>
/// Matrix Function.
/// </summary>
public class MatrixImpl: ModelElementImpl, Matrix
{
  public DocumentFormat.OpenXml.Math.Matrix? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Matrix?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MatrixImpl(): base() {}
  
  public MatrixImpl(DocumentFormat.OpenXml.Math.Matrix openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Matrix Properties.
  /// </summary>
  public DocumentModel.Math.MatrixProperties? MatrixProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
        if (item != null)
          return new DocumentModel.Math.MatrixPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.MatrixPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Collection<DocumentModel.Math.MatrixRow>? MatrixRows
  {
    get
    {
      if (_MatrixRows != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixRow>()
            .Select(item => new DocumentModel.Math.MatrixRowImpl(item)).ToList();
          _MatrixRows = new ObservableCollection<DocumentModel.Math.MatrixRow>(items);
        }
        else
          _MatrixRows = new ObservableCollection<DocumentModel.Math.MatrixRow>();
        _MatrixRows.CollectionChanged += _MatrixRows_CollectionChanged;
      }
      return _MatrixRows;
    }
    set
    {
      if (value != null && value != _MatrixRows && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixRow>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Math.MatrixRowImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Math.MatrixRow> observableCollection)
        _MatrixRows = observableCollection;
      else if (value != null)
        _MatrixRows = new ObservableCollection<DocumentModel.Math.MatrixRow>(value);
      else
       _MatrixRows = null;
    }
  }
  private ObservableCollection<DocumentModel.Math.MatrixRow>? _MatrixRows;
  
  private void _MatrixRows_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Math.MatrixRow>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Math.MatrixRowImpl valImpl)
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
              if (val is DocumentModel.Math.MatrixRowImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Math.MatrixRow>()
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
