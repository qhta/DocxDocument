namespace ModelGenApp.ViewModels;

//public class ShowTypeRoutedCommand: RoutedCommand
//{
//  public ShowTypeRoutedCommand(IRelayCommand relayCommand)
//  {
//    base.CanExecuteChanged += ShowTypeRoutedCommand_CanExecuteChanged;
//  }

//  private void ShowTypeRoutedCommand_CanExecuteChanged(object? sender, EventArgs e)
//  {
//    throw new NotImplementedException();
//  }
//}

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
    FillTypeSummaryAsync();
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
    if (typeInfo.TypeKind == TypeKind.@enum)
      return new EnumTypeInfoViewModel(phase, typeInfo, typeNameSelector);
    if (typeInfo.TypeKind == TypeKind.type)
      return new TypeInfoViewModel(phase, typeInfo, typeNameSelector);
    return new ClassInfoViewModel(phase, typeInfo, typeNameSelector);
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Kind)
    )]
  public TypeKind TypeKind => Model.TypeKind;

  public TNS TypeNameSelector { get; private set; }

  public PhaseResultsViewModel Phase { get; private set; }

  public bool IsTypeKindSelected(TKS tks) => Model.IsTypeKindSelected(tks);

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Acceptance),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.AcceptanceTooltip)
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

  public string? Name
  {
    get
    {
      if (TypeNameSelector.Target)
        return TargetName;
      else
        return OriginalName;
    }
  }

  public string? OriginalName => Model.GetFullName(false, TypeNameSelector.Namespace, TypeNameSelector.NsShortcut);

  public string? TargetName => Model.GetFullName(true, TypeNameSelector.Namespace, TypeNameSelector.NsShortcut);

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TypeName),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.TypeNameTooltip),
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

  [DataGridColumn(
    Header = "",
    HiddenHeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Problem),
    DataTemplateResourceKey = "ProblemMarkTemplate"
    )]
  public string? ValidationProblem
  {
    get
    {
      var errCode = Model.Errors?.FirstOrDefault(item => item.Phase == Phase.PhaseNum)?.Code;
      if (errCode != null)
      {
        var errCodeName = errCode?.ToString();
        if (errCodeName != null)
          return CommonStrings.ResourceManager.GetString(errCodeName);
      }
      return null;
    }
  }

  public string? FullName => Model.GetFullName(TypeNameSelector.Target, true, false);

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Description),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.DescriptionTooltip)
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

  public TypeSummaryViewModel TypeSummary { get; } = new TypeSummaryViewModel();

  protected async void FillTypeSummaryAsync()
  {
    await Task.Run(() => FillTypeSummary());
  }

  protected virtual void FillTypeSummary()
  {
    TypeSummary.Clear();
    if (Model.IsAcceptedAfter(Phase.PhaseNum))
      TypeSummary.Add(new TypePropViewModel("Acceptance", Acceptance));
    else
      TypeSummary.Add(new TypePropViewModel("Acceptance", new RedString(Acceptance.ToString()?.ToLower())));

    if (Model.HasProblems(Phase.PhaseNum))
      TypeSummary.Add(new TypePropViewModel("Validation", new RedString(this.ValidationProblem ?? "invalid")));

    TypeSummary.Add(new TypePropViewModel("Kind", TypeKind.ToString().ToLower()));
    TypeSummary.Add(new TypePropViewModel("Namespace", Model.OriginalNamespace));
    TypeSummary.Add(new TypePropViewModel("Name", Name));
    if (!String.IsNullOrEmpty(Model.TargetNamespace))
      TypeSummary.Add(new TypePropViewModel("Target namespace", Model.TargetNamespace));
    if (!String.IsNullOrEmpty(Model.NewName))
      TypeSummary.Add(new TypePropViewModel("New name", Model.NewName));
    if (Model.IsConverted)
    {
      var targetType = Model.GetConversionTarget();
      if (targetType != null)
        TypeSummary.Add(new TypePropViewModel("Converted to", new TypeInfoViewModel(Phase, targetType, TypeNameSelector)));
    }
    TypeSummary.Add(new TypePropViewModel("Description", new Description(Model.Description ?? "")));
  }

  public async void FillDetailsAsync()
  {
    await Task.Run(() => FillDetails());
  }

  public virtual void FillDetails()
  {
  }

  public async void RefreshDetailsAsync()
  {
    await Task.Run(() => RefreshDetails());
  }

  public virtual void RefreshDetails()
  {
  }

  /// <summary>
  /// Shown as Window.Title.
  /// </summary>
  public string Caption => TypeKind + " | " + Model.GetFullName(TypeNameSelector.Target, true, false);

  public virtual object? Members => null;


  #region ShowTypeCommand
  public Command ShowTypeCommand { get; private set; }

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
      WindowsManager.ShowWindow<TypeInfoWindow>(this);
    });

  }
  #endregion

  #region ShowErrorCommand
  public Command ShowErrorCommand { get; private set; }

  protected virtual bool ShowErrorCanExecute()
  {
    return ValidationProblem != null;
  }

  protected virtual void ShowErrorExecute()
  {
    Phase.ShowErrorFor(this);
  }
  #endregion

}

