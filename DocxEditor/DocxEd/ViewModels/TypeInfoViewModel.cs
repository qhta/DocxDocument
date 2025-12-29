namespace DocxEd.ViewModels;

/// <summary>
/// View model to represent <see cref="ModelGen.TypeInfo"/>.
/// </summary>
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  /// <summary>
  /// Initializating constructor.
  /// </summary>
  /// <param name="phase"><see cref="PhaseResultsViewModel"/> that represents processing phase needed to evaluate <see cref="Acceptance"/> property.</param>
  /// <param name="typeInfo"><see cref="ModelGen.TypeInfo"/> that holds type data.</param>
  /// <param name="typeNameSelector"><see cref="ModelGen.TNS"/> object data to select, which name (original/target) to get from <paramref name="typeInfo"></param>
  protected TypeInfoViewModel(PhaseResultsViewModel phase, TypeInfo typeInfo, TNS typeNameSelector) : base(typeInfo)
  {
    TypeNameSelector = typeNameSelector;
    Phase = phase;
    ShowTypeCommand = new RelayCommand(ShowTypeExecute, ShowTypeCanExecute) { Name = "ShowTypeCommand" };
    ShowErrorCommand = new RelayCommand(ShowErrorExecute, ShowErrorCanExecute) { Name = "ShowErrorCommand" };
    BusyMonitor.Instance.PropertyChanged += BusyMonitor_PropertyChanged;
    //FillTypeSummaryAsync();
    if (typeInfo.Schema != null)
      Schema = new ElementSchemaViewModel(typeInfo.Schema, typeInfo.Name);
  }

  public bool IsBusy => BusyMonitor.Instance.IsBusy;

  private void BusyMonitor_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (args.PropertyName == nameof(BusyMonitor.IsBusy))
      NotifyPropertyChanged(nameof(IsBusy));
  }

  /// <summary>
  /// Method to create instance of specific type according to <paramref name="typeInfo"/> TypeKind.
  /// </summary>
  /// <param name="phase"><see cref="PhaseResultsViewModel"/> that represents processing phase needed to evaluate <see cref="Acceptance"/> property.</param>
  /// <param name="typeInfo"><see cref="ModelGen.TypeInfo"/> that holds type data.</param>
  /// <param name="typeNameSelector"><see cref="ModelGen.TNS"/> object data to select, which name (original/target) to get from <paramref name="typeInfo"></param>
  /// <returns></returns>
  public static TypeInfoViewModel Create(PhaseResultsViewModel phase, TypeInfo typeInfo, TNS typeNameSelector)
  {
    if (typeInfo.TypeKind == TypeKind.@class || typeInfo.TypeKind == TypeKind.@interface || typeInfo.TypeKind == TypeKind.@struct)
      return new ClassInfoViewModel(phase, typeInfo, typeNameSelector);
    if (typeInfo.TypeKind == TypeKind.@enum)
      return new EnumTypeInfoViewModel(phase, typeInfo, typeNameSelector);
    return new TypeInfoViewModel(phase, typeInfo, typeNameSelector);
  }

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Kind)
    )]
  public TypeKind TypeKind => Model.TypeKind;

  public TNS TypeNameSelector { [DebuggerStepThrough] get; private set; }

  public PhaseResultsViewModel Phase { [DebuggerStepThrough] get; private set; }

  public bool IsTypeKindSelected(TKS tks) => Model.IsTypeKindSelected(tks);

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Acceptance),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.AcceptanceTooltip)
    )]
  public Acceptance Acceptance
  {
    get
    {
      Acceptance result = 0;
      if (Model.IsAcceptedAfter(Phase.PhaseNum))
        result |= Acceptance.accepted;
      if (Model.IsRejectedAfter(Phase.PhaseNum))
        result |= Acceptance.rejected;
      return result;
    }
  }

  public bool IsAbstract => Model.IsAbstract;

  public string? Name
  {
    get
    {
      if (TypeNameSelector.NTS == NTS.Target)
        return TargetTypeName;
      else
        return OriginalName;
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Namespace))]
  public String? Namespace 
  {
    get
    {
      if (TypeNameSelector.NTS == NTS.Target)
        return Model.TargetNamespace?.ToString();
      else
        return Model.OriginalNamespace.ToString();
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TypeName),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TypeNameTooltip),
    DataTemplateResourceKey = "TypeInfoLinkTemplate",
    SortMemberPath = "Type.Name",
    ClipboardContentPath = "Type.Name")]
  public TypeInfoViewModel? Type
  {
    get
    {
      var thisType = this.Model;
      if (thisType != null)
      {
        if (thisType.TypeKind == TypeKind.@enum)
          return new EnumTypeInfoViewModel(Phase, thisType, TypeNameSelector);
        if (thisType.TypeKind == TypeKind.type)
          return new TypeInfoViewModel(Phase, thisType, TypeNameSelector);
        return new ClassInfoViewModel(Phase, thisType, TypeNameSelector);
      }
      return null;
    }
  }


  public string? OriginalName => Model.GetFullName(false, TypeNameSelector.Namespace, TypeNameSelector.NsShortcut);

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetName),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetNameTooltip))]
  public string? TargetName => Model.NewName;

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.ConversionTarget),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetTypeTooltip))
    ]
  public String? ConversionTarget
  {
    get => Model.ConversionTarget?.Name;
  }

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetType),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.TargetTypeTooltip),
    DataTemplateResourceKey = "TypeInfoTargetLinkTemplate",
    SortMemberPath = "TargetTypeName",
    ClipboardContentPath = "TargetTypeName")
    ]
  public TypeInfoViewModel? TargetType
  {
    get
    {
      if (_TargetType == null && Model.IsAcceptedAfter(PPS.ConvertTypes) && Model.TargetType != null)
        _TargetType = TypeInfoViewModel.Create(Phase, Model.TargetType, TypeNameSelector);
      return _TargetType;
    }
  }
  public TypeInfoViewModel? _TargetType;

  public string? TargetTypeName
  {
    get
    {
      return Model.GetFullName(true, TypeNameSelector.Namespace, TypeNameSelector.NsShortcut);
    }
  }

  [DataGridColumn(
    Header = "",
    HiddenHeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Problem),
    DataTemplateResourceKey = "ErrorMarkButtonTemplate"
    )]
  public string? ValidationError
  {
    get
    {
      var errCode = Model.Errors?.FirstOrDefault(item => item.Phase == Phase.PhaseNum)?.Code;
      if (errCode != null)
      {
        var errCodeName = errCode?.ToString();
        if (errCodeName != null)
        {
          var msg = CommonStrings.ResourceManager.GetString(errCodeName);
          if (String.IsNullOrEmpty(msg))
            msg = errCodeName.DeCamelCase();
          return msg;
        }
      }
      return null;
    }
  }

  public string? FullName => Model.GetFullName(TypeNameSelector.NTS == NTS.Target, true, false);

  [DataGridColumn(
    HeaderResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.Description),
    HeaderTooltipResourceKey = "DocxEd.CommonStrings." + nameof(CommonStrings.DescriptionTooltip)
    )]
  public string? Description => Model.Description;

  public bool ShowFullTypeName
  {
    get => TypeNameSelector.Namespace;
    set
    {
      if (TypeNameSelector.Namespace != value)
      {
        TypeNameSelector.Namespace = value;
        NotifyPropertyChanged(nameof(ShowFullTypeName));
        RefreshDetailsAsync();
      }
    }
  }

  public TypeSummaryViewModel TypeSummary
  {
    get
    {
      if (_TypeSummary.IsEmpty)
        FillTypeSummaryAsync();
      return _TypeSummary;
    }
  }

  protected TypeSummaryViewModel _TypeSummary = new TypeSummaryViewModel();
  protected async void FillTypeSummaryAsync()
  {
    await Task.Factory.StartNew(() => FillTypeSummary());
  }

  protected virtual void FillTypeSummary()
  {
    if (_TypeSummary.IsEmpty)
    {
      _TypeSummary.Clear();
      _TypeSummary.Add(new TypePropViewModel(CommonStrings.Name, Name));
      if (Model.IsAcceptedAfter(Phase.PhaseNum))
        _TypeSummary.Add(new TypePropViewModel(CommonStrings.Acceptance, Acceptance));
      else
        _TypeSummary.Add(new TypePropViewModel(CommonStrings.Acceptance, new RedString(Acceptance.ToString()?.ToLower())));

      if (Model.IsInvalid(Phase.PhaseNum))
        _TypeSummary.Add(new TypePropViewModel(CommonStrings.ValidationError, new RedString(this.ValidationError)));

      var kindStr = TypeKind.ToString().ToLower();
      if (IsAbstract) kindStr = "abstract " + kindStr;
      _TypeSummary.Add(new TypePropViewModel(CommonStrings.Kind, kindStr));

      _TypeSummary.Add(new TypePropViewModel(CommonStrings.Namespace, Model.OriginalNamespace));

      if (!String.IsNullOrEmpty(Model.TargetNamespace))
        _TypeSummary.Add(new TypePropViewModel(CommonStrings.TargetNamespace, Model.TargetNamespace));

      if (!String.IsNullOrEmpty(Model.NewName))
        TypeSummary.Add(new TypePropViewModel(CommonStrings.TargetName, Model.NewName));

      if (Model.IsConverted)
      {
        var targetType = Model.GetConversionTarget();
        if (targetType != null)
          _TypeSummary.Add(new TypePropViewModel(CommonStrings.TargetType, new TypeInfoViewModel(Phase, targetType, TypeNameSelector)));
      }

      if (Model.Description != null)
        _TypeSummary.Add(new TypePropViewModel(CommonStrings.Description, new Description(Model.Description)));
    }
  }

  public async void FillDetailsAsync()
  {
    await Task.Factory.StartNew(() => FillDetails());
  }

  public virtual void FillDetails()
  {
    FillIncomingRelationshipsAsync();
  }

  public async void RefreshDetailsAsync()
  {
    await Task.Factory.StartNew(() => RefreshDetails());
  }

  public virtual void RefreshDetails()
  {
    RefreshRelationshipsAsync();
  }

  /// <summary>
  /// Shown as Window.Title.
  /// </summary>
  public string Caption => TypeKind + " | " + Model.GetFullName(TypeNameSelector.NTS == NTS.Target, true, false);

  public virtual object? Members => null;

  public bool IsMembersVisible => Members != null;

  public ElementSchemaViewModel? Schema { [DebuggerStepThrough] get; private set; }

  public bool IsSchemaVisible => Schema != null;

  #region Relationships

  public TypeRelationshipsListViewModel IncomingRelationships
  {
    get
    {
      if (_IncomingRelationships == null)
      {
        _IncomingRelationships = new TypeRelationshipsListViewModel(Phase, this, "IncomingRelationships", TypeNameSelector);
        FillIncomingRelationshipsAsync();
      }
      return _IncomingRelationships;
    }
  }
  private TypeRelationshipsListViewModel _IncomingRelationships = null!;

  public bool HasIncomingRelationships => _IncomingRelationships != null;
  public TypeRelationshipsListViewModel OutgoingRelationships
  {
    get
    {
      if (_OutgoingRelationships == null)
      {
        _OutgoingRelationships = new TypeRelationshipsListViewModel(Phase, this, "OutgoingRelationships", TypeNameSelector);
        FillOutgoingRelationshipsAsync();
      }
      return _OutgoingRelationships;
    }
  }
  private TypeRelationshipsListViewModel _OutgoingRelationships = null!;

  public bool HasOutgoingRelationships => _OutgoingRelationships != null;

  public async void FillIncomingRelationshipsAsync()
  {
    await Task.Factory.StartNew(() => FillIncomingRelationships());
  }
  public void FillIncomingRelationships()
  {
    if (_IncomingRelationships == null)
      _IncomingRelationships = new TypeRelationshipsListViewModel(Phase, this, "IncomingRelationships", TypeNameSelector);
    IncomingRelationships.Clear();
    foreach (var relationship in Model.GetIncomingRelationships().ToList())
      IncomingRelationships.Add(new TypeRelationshipViewModel(Phase, this, relationship, TypeNameSelector, true));
  }

  public async void FillOutgoingRelationshipsAsync()
  {
    await Task.Factory.StartNew(() => FillOutgoingRelationships());
  }

  public void FillOutgoingRelationships()
  {
    if (_OutgoingRelationships == null)
      _OutgoingRelationships = new TypeRelationshipsListViewModel(Phase, this, "OutgoingRelationships", TypeNameSelector);
    OutgoingRelationships.Clear();
    foreach (var relationship in Model.GetOutgoingRelationships().ToList())
      OutgoingRelationships.Add(new TypeRelationshipViewModel(Phase, this, relationship, TypeNameSelector, false));
  }

  public async void RefreshRelationshipsAsync()
  {
    await Task.Factory.StartNew(() => RefreshRelationships());
  }

  public void RefreshRelationships()
  {
    RefreshIncomingRelationships();
    RefreshOutgoingRelationships();
  }

  public void RefreshIncomingRelationships()
  {
    if (_IncomingRelationships == null)
      _IncomingRelationships = new TypeRelationshipsListViewModel(Phase, this, "IncomingRelationships", TypeNameSelector);
    IncomingRelationships.ShowFullTypeName = this.ShowFullTypeName;
    var relationships = Model.GetIncomingRelationships().ToList();
    var newRelationships = new List<TypeRelationship>();
    foreach (var relationship in relationships)
      if (!IncomingRelationships.Any(vm => vm.Model == relationship))
        newRelationships.Add(relationship);
    foreach (var relationship in newRelationships)
      IncomingRelationships.Add(new TypeRelationshipViewModel(Phase, this, relationship, TypeNameSelector, true));
  }
  public void RefreshOutgoingRelationships()
  {
    if (_OutgoingRelationships == null)
      _OutgoingRelationships = new TypeRelationshipsListViewModel(Phase, this, "OutgoingRelationships", TypeNameSelector);
    OutgoingRelationships.ShowFullTypeName = this.ShowFullTypeName;
    var relationships = Model.GetOutgoingRelationships().ToList();
    var newRelationships = new List<TypeRelationship>();
    foreach (var relationship in relationships)
      if (!OutgoingRelationships.Any(vm => vm.Model == relationship))
        newRelationships.Add(relationship);
    foreach (var relationship in newRelationships)
      OutgoingRelationships.Add(new TypeRelationshipViewModel(Phase, this, relationship, TypeNameSelector, false));
  }
  #endregion

  #region ShowTypeCommand
  public Command ShowTypeCommand { [DebuggerStepThrough] get; private set; }

  protected virtual bool ShowTypeCanExecute()
  {
    return Model != null;
  }

  protected virtual void ShowTypeExecute()
  {
    // Note: Dispatcher?.BeginInvoke is needed to avoid activating the data grid after opening new window.
    this.Dispatcher?.BeginInvoke(() =>
    {
      this.FillTypeSummaryAsync();
      this.FillDetailsAsync();
      //Debug.WriteLine($"TypeInfoViewModel.ShowTypeExecute({this.GetType()})");
      WindowsManager.ShowWindow<TypeInfoWindow>(this);
    });

  }
  #endregion

  #region ShowErrorCommand
  public Command ShowErrorCommand { [DebuggerStepThrough] get; private set; }

  protected virtual bool ShowErrorCanExecute()
  {
    return ValidationError != null;
  }

  protected virtual void ShowErrorExecute()
  {
    Phase.ShowErrorFor(this);
  }
  #endregion

}

