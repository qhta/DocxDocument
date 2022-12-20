namespace DocumentModel.UI;

/// <summary>
/// Defines the ComboBox Class.
/// </summary>
public partial class ComboBoxImpl: ModelElementImpl, ComboBox
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.ComboBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.ComboBox?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ComboBoxImpl(): base() {}
  
  public ComboBoxImpl(DocumentFormat.OpenXml.Office.CustomUI.ComboBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// showItemImage
  /// </summary>
  public Boolean? ShowItemImage
  {
    get => (System.Boolean?)OpenXmlElement?.ShowItemImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowItemImage = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getItemCount
  /// </summary>
  public String? GetItemCount
  {
    get => (System.String?)OpenXmlElement?.GetItemCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemCount = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemLabel
  /// </summary>
  public String? GetItemLabel
  {
    get => (System.String?)OpenXmlElement?.GetItemLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemScreentip
  /// </summary>
  public String? GetItemScreentip
  {
    get => (System.String?)OpenXmlElement?.GetItemScreentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemScreentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemSupertip
  /// </summary>
  public String? GetItemSupertip
  {
    get => (System.String?)OpenXmlElement?.GetItemSupertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemSupertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemImage
  /// </summary>
  public String? GetItemImage
  {
    get => (System.String?)OpenXmlElement?.GetItemImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getItemID
  /// </summary>
  public String? GetItemID
  {
    get => (System.String?)OpenXmlElement?.GetItemID?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetItemID = (System.String?)value;
    }
  }
  
  /// <summary>
  /// sizeString
  /// </summary>
  public String? SizeString
  {
    get => (System.String?)OpenXmlElement?.SizeString?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SizeString = (System.String?)value;
    }
  }
  
  /// <summary>
  /// invalidateContentOnDrop
  /// </summary>
  public Boolean? InvalidateContentOnDrop
  {
    get => (System.Boolean?)OpenXmlElement?.InvalidateContentOnDrop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InvalidateContentOnDrop = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  public Boolean? Enabled
  {
    get => (System.Boolean?)OpenXmlElement?.Enabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Enabled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  public String? GetEnabled
  {
    get => (System.String?)OpenXmlElement?.GetEnabled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetEnabled = (System.String?)value;
    }
  }
  
  /// <summary>
  /// image
  /// </summary>
  public String? Image
  {
    get => (System.String?)OpenXmlElement?.Image?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Image = (System.String?)value;
    }
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public String? ImageMso
  {
    get => (System.String?)OpenXmlElement?.ImageMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  public String? GetImage
  {
    get => (System.String?)OpenXmlElement?.GetImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetImage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// maxLength
  /// </summary>
  public Int32? MaxLength
  {
    get => (System.Int32?)OpenXmlElement?.MaxLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxLength = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// getText
  /// </summary>
  public String? GetText
  {
    get => (System.String?)OpenXmlElement?.GetText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetText = (System.String?)value;
    }
  }
  
  /// <summary>
  /// onChange
  /// </summary>
  public String? OnChange
  {
    get => (System.String?)OpenXmlElement?.OnChange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.OnChange = (System.String?)value;
    }
  }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public String? IdQ
  {
    get => (System.String?)OpenXmlElement?.IdQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  public String? IdMso
  {
    get => (System.String?)OpenXmlElement?.IdMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IdMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tag
  /// </summary>
  public String? Tag
  {
    get => (System.String?)OpenXmlElement?.Tag?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Tag = (System.String?)value;
    }
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public String? Screentip
  {
    get => (System.String?)OpenXmlElement?.Screentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Screentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  public String? GetScreentip
  {
    get => (System.String?)OpenXmlElement?.GetScreentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetScreentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public String? Supertip
  {
    get => (System.String?)OpenXmlElement?.Supertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Supertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  public String? GetSupertip
  {
    get => (System.String?)OpenXmlElement?.GetSupertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetSupertip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// label
  /// </summary>
  public String? Label
  {
    get => (System.String?)OpenXmlElement?.Label?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Label = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  public String? GetLabel
  {
    get => (System.String?)OpenXmlElement?.GetLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public String? InsertAfterMso
  {
    get => (System.String?)OpenXmlElement?.InsertAfterMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public String? InsertAfterQ
  {
    get => (System.String?)OpenXmlElement?.InsertAfterQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertAfterQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ
  {
    get => (System.String?)OpenXmlElement?.InsertBeforeQ?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsertBeforeQ = (System.String?)value;
    }
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible
  {
    get => (System.Boolean?)OpenXmlElement?.Visible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Visible = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible
  {
    get => (System.String?)OpenXmlElement?.GetVisible?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetVisible = (System.String?)value;
    }
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  public String? Keytip
  {
    get => (System.String?)OpenXmlElement?.Keytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Keytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  public String? GetKeytip
  {
    get => (System.String?)OpenXmlElement?.GetKeytip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetKeytip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  public Boolean? ShowLabel
  {
    get => (System.Boolean?)OpenXmlElement?.ShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowLabel = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  public String? GetShowLabel
  {
    get => (System.String?)OpenXmlElement?.GetShowLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// showImage
  /// </summary>
  public Boolean? ShowImage
  {
    get => (System.Boolean?)OpenXmlElement?.ShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowImage = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// getShowImage
  /// </summary>
  public String? GetShowImage
  {
    get => (System.String?)OpenXmlElement?.GetShowImage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetShowImage = (System.String?)value;
    }
  }
  
  public Collection<DocumentModel.UI.Item>? Items
  {
    get
    {
      if (_Items == null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Item>()
            .Select(item => new DocumentModel.UI.ItemImpl(item)).ToList();
          _Items = new ObservableCollection<DocumentModel.UI.Item>(items);
        }
        else
          _Items = new ObservableCollection<DocumentModel.UI.Item>();
        _Items.CollectionChanged += _Items_CollectionChanged;
      }
      return _Items;
    }
    set
    {
      if (value != null && value != _Items && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Item>();
        foreach (var val in value)
        {
          if (val is DocumentModel.UI.ItemImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.UI.Item> observableCollection)
        _Items = observableCollection;
      else if (value != null)
        _Items = new ObservableCollection<DocumentModel.UI.Item>(value);
      else
       _Items = null;
    }
  }
  private ObservableCollection<DocumentModel.UI.Item>? _Items;
  
  private void _Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Item>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.UI.ItemImpl valImpl)
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
              if (val is DocumentModel.UI.ItemImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Item>()
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
