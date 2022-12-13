namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines Styles.
/// </summary>
public class StylesImpl: ModelElementImpl, Styles
{
  public DocumentFormat.OpenXml.Wordprocessing.Styles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Styles?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StylesImpl(): base() {}
  
  public StylesImpl(DocumentFormat.OpenXml.Wordprocessing.Styles openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Default Paragraph and Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.DocDefaults? DocDefaults
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Latent Style Information.
  /// </summary>
  public DocumentModel.Wordprocessing.LatentStyles? LatentStyles
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<DocumentModel.Wordprocessing.Style>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Style>()
            .Select(item => new DocumentModel.Wordprocessing.StyleImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Style>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Wordprocessing.Style>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Style>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Wordprocessing.StyleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.Style> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Wordprocessing.Style>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.Style>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.Style>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Wordprocessing.StyleImpl valImpl)
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
        if (val is DocumentModel.Wordprocessing.StyleImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.Style>()
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
