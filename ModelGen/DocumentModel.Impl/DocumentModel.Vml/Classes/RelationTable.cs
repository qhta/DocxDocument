namespace DocumentModel.Vml;

/// <summary>
/// Diagram Relationship Table.
/// </summary>
public class RelationTableImpl: ModelElementImpl, RelationTable
{
  public DocumentFormat.OpenXml.Vml.Office.RelationTable? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.RelationTable?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RelationTableImpl(): base() {}
  
  public RelationTableImpl(DocumentFormat.OpenXml.Vml.Office.RelationTable openXmlElement): base(openXmlElement)
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
  
  public Collection<DocumentModel.Vml.Relation>? Relations
  {
    get
    {
      if (_Relations != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Relation>()
            .Select(item => new DocumentModel.Vml.RelationImpl(item)).ToList();
          _Relations = new ObservableCollection<DocumentModel.Vml.Relation>(items);
        }
        else
          _Relations = new ObservableCollection<DocumentModel.Vml.Relation>();
        _Relations.CollectionChanged += _Relations_CollectionChanged;
      }
      return _Relations;
    }
    set
    {
      if (value != null && value != _Relations && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Relation>();
        foreach (var val in value)
        {
        if (val is DocumentModel.Vml.RelationImpl valImpl)
        {
          var item = valImpl.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        };
        }
      }
      if (value is ObservableCollection<DocumentModel.Vml.Relation> observableCollection)
        _Relations = observableCollection;
      else if (value != null)
        _Relations = new ObservableCollection<DocumentModel.Vml.Relation>(value);
      else
       _Relations = null;
    }
  }
  private ObservableCollection<DocumentModel.Vml.Relation>? _Relations;
  
  private void _Relations_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Vml.Office.Relation>();
          break;
        case NotifyCollectionChangedAction.Add:
          foreach (var val in args.NewItems)
          {
          if (val is DocumentModel.Vml.RelationImpl valImpl)
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
              if (val is DocumentModel.Vml.RelationImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Vml.Office.Relation>()
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
