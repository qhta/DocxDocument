namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
public class AlgorithmImpl: ModelElementImpl, Algorithm
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AlgorithmImpl(): base() {}
  
  public AlgorithmImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.AlgorithmKind? Type
  {
    get => (DocumentModel.Drawings.Diagrams.AlgorithmKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.AlgorithmValues?)value;
    }
  }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public UInt32? Revision
  {
    get => (System.UInt32?)OpenXmlElement?.Revision?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Revision = (System.UInt32?)value;
    }
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Parameter>? Parameters
  {
    get
    {
      if (_Parameters != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ParameterImpl(item)).ToList();
          _Parameters = new ObservableCollection<DocumentModel.Drawings.Diagrams.Parameter>(items);
        }
        else
          _Parameters = new ObservableCollection<DocumentModel.Drawings.Diagrams.Parameter>();
        _Parameters.CollectionChanged += _Parameters_CollectionChanged;
      }
      return _Parameters;
    }
    set
    {
      if (value != null && value != _Parameters && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.ParameterImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Parameter> observableCollection)
        _Parameters = observableCollection;
      else if (value != null)
        _Parameters = new ObservableCollection<DocumentModel.Drawings.Diagrams.Parameter>(value);
      else
       _Parameters = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Parameter>? _Parameters;
  
  private void _Parameters_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.ParameterImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ParameterImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Parameter>()
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
  
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
