namespace DocumentModel.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public class FormulasImpl: ModelElementImpl, Formulas
{
  public DocumentFormat.OpenXml.Vml.Formulas? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Formulas?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FormulasImpl(): base() {}
  
  public FormulasImpl(DocumentFormat.OpenXml.Vml.Formulas openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<DocumentModel.Vml.Formula>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Formula>()
            .Select(item => new DocumentModel.Vml.FormulaImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Vml.Formula>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Vml.Formula>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Formula>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Vml.FormulaImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Vml.Formula> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Vml.Formula>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Vml.Formula>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Formula>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Vml.FormulaImpl valImpl)
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
        if (val is DocumentModel.Vml.FormulaImpl valImpl)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Formula>()
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
