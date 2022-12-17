namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Columns Class.
/// </summary>
public class ColumnsImpl: ModelElementImpl, Columns
{
  public DocumentFormat.OpenXml.Wordprocessing.Columns? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Columns?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColumnsImpl(): base() {}
  
  public ColumnsImpl(DocumentFormat.OpenXml.Wordprocessing.Columns openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Equal Column Widths
  /// </summary>
  public Boolean? EqualWidth
  {
    get => (System.Boolean?)OpenXmlElement?.EqualWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EqualWidth = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Spacing Between Equal Width Columns
  /// </summary>
  public String? Space
  {
    get => (System.String?)OpenXmlElement?.Space?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Space = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Number of Equal Width Columns
  /// </summary>
  public Int16? ColumnCount
  {
    get => (System.Int16?)OpenXmlElement?.ColumnCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColumnCount = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Draw Line Between Columns
  /// </summary>
  public Boolean? Separator
  {
    get => (System.Boolean?)OpenXmlElement?.Separator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Separator = (System.Boolean?)value;
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.Column>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Column>()
            .Select(item => new DocumentModel.Wordprocessing.ColumnImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Column>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Column>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Column>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.ColumnImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Column> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.Column>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Column>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Column>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.ColumnImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.ColumnImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Column>()
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
