namespace DocumentModel;

/// <summary>
/// Defines the BackstageComboBox Class.
/// </summary>
public partial class BackstageComboBoxImpl: ModelElementImpl, BackstageComboBox
{
  public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackstageComboBoxImpl(): base() {}
  
  public BackstageComboBoxImpl(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
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
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId
  {
    get => (System.String?)OpenXmlElement?.QualifiedId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QualifiedId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
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
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? AlignLabel
  {
    get => (DocumentModel.ExpandKind?)OpenXmlElement?.AlignLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlignLabel = (DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues?)value;
    }
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? Expand
  {
    get => (DocumentModel.ExpandKind?)OpenXmlElement?.Expand?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Expand = (DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues?)value;
    }
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
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
  /// getEnabled, this property is only available in Office 2010 and later.
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
  /// label, this property is only available in Office 2010 and later.
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
  /// getLabel, this property is only available in Office 2010 and later.
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
  /// visible, this property is only available in Office 2010 and later.
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
  /// getVisible, this property is only available in Office 2010 and later.
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
  /// keytip, this property is only available in Office 2010 and later.
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
  /// getKeytip, this property is only available in Office 2010 and later.
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
  /// getText, this property is only available in Office 2010 and later.
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
  /// onChange, this property is only available in Office 2010 and later.
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
  /// sizeString, this property is only available in Office 2010 and later.
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
  /// getItemCount, this property is only available in Office 2010 and later.
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
  /// getItemLabel, this property is only available in Office 2010 and later.
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
  /// getItemID, this property is only available in Office 2010 and later.
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
  
  public Collection<DocumentModel.BackstageItemType>? ItemBackstageItems
  {
    get
    {
      if (_ItemBackstageItems != null)
      {
        if (OpenXmlElement != null)
        {
          var items = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem>()
            .Select(item => new DocumentModel.BackstageItemTypeImpl(item)).ToList();
          _ItemBackstageItems = new ObservableCollection<DocumentModel.BackstageItemType>(items);
        }
        else
          _ItemBackstageItems = new ObservableCollection<DocumentModel.BackstageItemType>();
        _ItemBackstageItems.CollectionChanged += _ItemBackstageItems_CollectionChanged;
      }
      return _ItemBackstageItems;
    }
    set
    {
      if (value != null && value != _ItemBackstageItems && OpenXmlElement!=null)
      {
        OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem>();
        foreach (var val in value)
        {
          if (val is DocumentModel.BackstageItemTypeImpl valImpl)
          {
            var item = valImpl.OpenXmlElement;
            if (item != null)
              OpenXmlElement.AddChild(item);
          };
        }
      }
      if (value is ObservableCollection<DocumentModel.BackstageItemType> observableCollection)
        _ItemBackstageItems = observableCollection;
      else if (value != null)
        _ItemBackstageItems = new ObservableCollection<DocumentModel.BackstageItemType>(value);
      else
       _ItemBackstageItems = null;
    }
  }
  private ObservableCollection<DocumentModel.BackstageItemType>? _ItemBackstageItems;
  
  private void _ItemBackstageItems_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (OpenXmlElement != null)
    {
      switch (args.Action)
      {
        case NotifyCollectionChangedAction.Reset:
          OpenXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem>();
          break;
        case NotifyCollectionChangedAction.Add:
          if (args.NewItems != null)
          foreach (var val in args.NewItems)
          {
            if (val is DocumentModel.BackstageItemTypeImpl valImpl)
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
              if (val is DocumentModel.BackstageItemTypeImpl valImpl)
              {
                  var oldItem = OpenXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem>()
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
