namespace DocumentModel.Wordprocessing;

/// <summary>
/// Latent Style Information.
/// </summary>
public class LatentStylesImpl: ModelElementImpl, LatentStyles
{
  public DocumentFormat.OpenXml.Wordprocessing.LatentStyles? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LatentStyles?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LatentStylesImpl(): base() {}
  
  public LatentStylesImpl(DocumentFormat.OpenXml.Wordprocessing.LatentStyles openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Default Style Locking Setting
  /// </summary>
  public Boolean? DefaultLockedState
  {
    get => (System.Boolean?)OpenXmlElement?.DefaultLockedState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultLockedState = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default User Interface Priority Setting
  /// </summary>
  public Int32? DefaultUiPriority
  {
    get => (System.Int32?)OpenXmlElement?.DefaultUiPriority?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultUiPriority = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Default Semi-Hidden Setting
  /// </summary>
  public Boolean? DefaultSemiHidden
  {
    get => (System.Boolean?)OpenXmlElement?.DefaultSemiHidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultSemiHidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default Hidden Until Used Setting
  /// </summary>
  public Boolean? DefaultUnhideWhenUsed
  {
    get => (System.Boolean?)OpenXmlElement?.DefaultUnhideWhenUsed?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultUnhideWhenUsed = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default Primary Style Setting
  /// </summary>
  public Boolean? DefaultPrimaryStyle
  {
    get => (System.Boolean?)OpenXmlElement?.DefaultPrimaryStyle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DefaultPrimaryStyle = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Latent Style Count
  /// </summary>
  public Int32? Count
  {
    get => (System.Int32?)OpenXmlElement?.Count?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Count = (System.Int32?)value;
    }
  }
  
  public Collection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>? LatentStyleExceptionInfos
  {
    get
    {
      if (_LatentStyleExceptionInfos != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>()
            .Select(item => new DocumentModel.Wordprocessing.LatentStyleExceptionInfoImpl(item)).ToList();
          _LatentStyleExceptionInfos = new ObservableCollection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>(items);
        }
        else
          _LatentStyleExceptionInfos = new ObservableCollection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>();
        _LatentStyleExceptionInfos.CollectionChanged += _LatentStyleExceptionInfos_CollectionChanged;
      }
      return _LatentStyleExceptionInfos;
    }
    set
    {
      if (value != null && value != _LatentStyleExceptionInfos && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Wordprocessing.LatentStyleExceptionInfoImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo> observableCollection)
        _LatentStyleExceptionInfos = observableCollection;
      else if (value != null)
        _LatentStyleExceptionInfos = new ObservableCollection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>(value);
      else
       _LatentStyleExceptionInfos = null;
    }
  }
  private ObservableCollection<DocumentModel.Wordprocessing.LatentStyleExceptionInfo>? _LatentStyleExceptionInfos;
  
  private void _LatentStyleExceptionInfos_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Wordprocessing.LatentStyleExceptionInfoImpl valImpl)
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
              if (val is DocumentModel.Wordprocessing.LatentStyleExceptionInfoImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.LatentStyleExceptionInfo>()
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
