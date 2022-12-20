namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public partial class ExtraColorSchemeListImpl: ModelElementImpl, ExtraColorSchemeList
{
  public DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ExtraColorSchemeListImpl(): base() {}
  
  public ExtraColorSchemeListImpl(DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.ExtraColorScheme>? ExtraColorSchemes
  {
    get
    {
      if (_ExtraColorSchemes != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>()
            .Select(item => new DocumentModel.Drawings.ExtraColorSchemeImpl(item)).ToList();
          _ExtraColorSchemes = new ObservableCollection<DocumentModel.Drawings.ExtraColorScheme>(items);
        }
        else
          _ExtraColorSchemes = new ObservableCollection<DocumentModel.Drawings.ExtraColorScheme>();
        _ExtraColorSchemes.CollectionChanged += _ExtraColorSchemes_CollectionChanged;
      }
      return _ExtraColorSchemes;
    }
    set
    {
      if (value != null && value != _ExtraColorSchemes && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ExtraColorSchemeImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ExtraColorScheme> observableCollection)
        _ExtraColorSchemes = observableCollection;
      else if (value != null)
        _ExtraColorSchemes = new ObservableCollection<DocumentModel.Drawings.ExtraColorScheme>(value);
      else
       _ExtraColorSchemes = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ExtraColorScheme>? _ExtraColorSchemes;
  
  private void _ExtraColorSchemes_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ExtraColorSchemeImpl valImpl)
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
              if (val is DocumentModel.Drawings.ExtraColorSchemeImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.ExtraColorScheme>()
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
