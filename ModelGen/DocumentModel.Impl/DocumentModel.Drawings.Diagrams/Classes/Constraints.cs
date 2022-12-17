namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Constraint List.
/// </summary>
public class ConstraintsImpl: ModelElementImpl, Constraints
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Constraints? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Constraints?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConstraintsImpl(): base() {}
  
  public ConstraintsImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Constraints openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Drawings.Diagrams.Constraint>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>()
            .Select(item => new DocumentModel.Drawings.Diagrams.ConstraintImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Drawings.Diagrams.Constraint>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Drawings.Diagrams.Constraint>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>();
        foreach (var val in value)
        {
          if (val is DocumentModel.Drawings.Diagrams.ConstraintImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.Drawings.Diagrams.Constraint> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Drawings.Diagrams.Constraint>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Drawings.Diagrams.Constraint>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.Drawings.Diagrams.ConstraintImpl valImpl)
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
              if (val is DocumentModel.Drawings.Diagrams.ConstraintImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Diagrams.Constraint>()
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
