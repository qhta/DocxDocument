namespace DocumentModel.Vml;

/// <summary>
/// Rule Set.
/// </summary>
public class RulesImpl: ModelElementImpl, Rules
{
  public DocumentFormat.OpenXml.Vml.Office.Rules? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Rules?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RulesImpl(): base() {}
  
  public RulesImpl(DocumentFormat.OpenXml.Vml.Office.Rules openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  public Collection<DocumentModel.Vml.Rule>? Items
  {
    get
    {
      if (_Items != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Rule>()
            .Select(item => new DocumentModel.Vml.RuleImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.Vml.Rule>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.Vml.Rule>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Rule>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Vml.RuleImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Vml.Rule> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.Vml.Rule>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.Vml.Rule>? _Items;
  
  private void _Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Rule>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Vml.RuleImpl valImpl)
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
              if (val is DocumentModel.Vml.RuleImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Rule>()
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
