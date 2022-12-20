namespace DocumentModel.Wordprocessing;

/// <summary>
/// Drop-Down List Form Field Properties.
/// </summary>
public partial class DropDownListFormFieldImpl: ModelElementImpl, DropDownListFormField
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DropDownListFormFieldImpl(): base() {}
  
  public DropDownListFormFieldImpl(DocumentFormat.OpenXml.Wordprocessing.DropDownListFormField openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Drop-Down List Selection.
  /// </summary>
  public Int32? DropDownListSelection
  {
    get => (System.Int32?)OpenXmlElement?.DropDownListSelection?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DropDownListSelection != null)
        {
          if (value is not null)
            OpenXmlElement.DropDownListSelection.Val = (System.Int32?)value;
          else
            OpenXmlElement.DropDownListSelection = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DropDownListSelection = new DocumentFormat.OpenXml.Wordprocessing.DropDownListSelection{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Default Drop-Down List Item Index.
  /// </summary>
  public Int32? DefaultDropDownListItemIndex
  {
    get => (System.Int32?)OpenXmlElement?.DefaultDropDownListItemIndex?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DefaultDropDownListItemIndex != null)
        {
          if (value is not null)
            OpenXmlElement.DefaultDropDownListItemIndex.Val = (System.Int32?)value;
          else
            OpenXmlElement.DefaultDropDownListItemIndex = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DefaultDropDownListItemIndex = new DocumentFormat.OpenXml.Wordprocessing.DefaultDropDownListItemIndex{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  public Collection<System.String>? ListEntryFormFields
  {
    get
    {
      if (_ListEntryFormFields == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>()
            .Select(item => item.Val?.Value ?? "").ToList();
          _ListEntryFormFields = new ObservableCollection<System.String>(items);
        }
        else
          _ListEntryFormFields = new ObservableCollection<System.String>();
        _ListEntryFormFields.CollectionChanged += _ListEntryFormFields_CollectionChanged;
      }
      return _ListEntryFormFields;
    }
    set
    {
      if (value != null && value != _ListEntryFormFields && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>();
        foreach (var val in value)
        {
          if (val is string str)
          {
            var item = new DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField{ Val = str };
            OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<System.String> observableCollection)
        _ListEntryFormFields = observableCollection;
      else if (value != null)
        _ListEntryFormFields = new ObservableCollection<System.String>(value);
      else
       _ListEntryFormFields = null;
    }
  }
  private ObservableCollection<System.String>? _ListEntryFormFields;
  
  private void _ListEntryFormFields_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
          if (val is string str)
          {
            var newItem = new DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField{ Val = str };
            OpenXmlElement.AddChild(newItem);
          };
          }
          break;
        case NotifyCollectionChangedAction.Remove:
          if (args.OldItems != null)
          foreach (var val in args.OldItems)
          {
        if (val is string str)
        {
            var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Wordprocessing.ListEntryFormField>()
                          .FirstOrDefault(anItem => anItem.Val == str);
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
