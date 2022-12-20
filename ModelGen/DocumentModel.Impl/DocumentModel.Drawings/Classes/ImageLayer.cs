namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public partial class ImageLayerImpl: ModelElementImpl, ImageLayer
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ImageLayerImpl(): base() {}
  
  public ImageLayerImpl(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Embed
  {
    get => (System.String?)OpenXmlElement?.Embed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Embed = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.Drawings.ImageEffect>? ImageEffects
  {
    get
    {
      if (_ImageEffects == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>()
            .Select(item => new DocumentModel.Drawings.ImageEffectImpl(item)).ToList();
          _ImageEffects = new ObservableCollection<DocumentModel.Drawings.ImageEffect>(items);
        }
        else
          _ImageEffects = new ObservableCollection<DocumentModel.Drawings.ImageEffect>();
        _ImageEffects.CollectionChanged += _ImageEffects_CollectionChanged;
      }
      return _ImageEffects;
    }
    set
    {
      if (value != null && value != _ImageEffects && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.ImageEffectImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.ImageEffect> observableCollection)
        _ImageEffects = observableCollection;
      else if (value != null)
        _ImageEffects = new ObservableCollection<DocumentModel.Drawings.ImageEffect>(value);
      else
       _ImageEffects = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.ImageEffect>? _ImageEffects;
  
  private void _ImageEffects_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.ImageEffectImpl valImpl)
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
              if (val is DocumentModel.Drawings.ImageEffectImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>()
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
