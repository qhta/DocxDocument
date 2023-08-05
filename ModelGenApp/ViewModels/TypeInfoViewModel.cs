using ModelGen;

namespace ModelGenApp.ViewModels;
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  protected TypeInfoViewModel(PhaseViewModel phase, TypeInfo typeInfo, NKS typeNameSelector) : base(typeInfo)
  {
    TypeNameSelector = typeNameSelector;
    Phase = phase;
    ShowTypeCommand = new RelayCommand(ShowTypeExecute, ShowTypeCanExecute) { Name = "ShowTypeCommand" };
    ShowErrorCommand = new RelayCommand(ShowErrorExecute, ShowErrorCanExecute) { Name = "ShowErrorCommand" };
    FillTypeSummaryAsync();
  }

  public static TypeInfoViewModel Create(PhaseViewModel phase, TypeInfo typeInfo, NKS typeNameSelector)
  {
    if (typeInfo.TypeKind==TypeKind.Enum)
      return new EnumTypeInfoViewModel(phase, typeInfo, typeNameSelector);
    if (typeInfo.TypeKind==TypeKind.Type)
      return new TypeInfoViewModel(phase, typeInfo, typeNameSelector);
    return new ClassInfoViewModel(phase, typeInfo, typeNameSelector);
  }

  [DataGridColumn]
  public TypeKind TypeKind => Model.TypeKind;

  public NKS TypeNameSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  public bool IsTypeKindSelected(TKS tks) => Model.IsTypeKindSelected(tks);

  [DataGridColumn]
  public string Acceptance
  {
    get
    {
      if (Model.IsAcceptedAfter(Phase.PhaseNum))
        return "accepted";
      return "rejected";
    }
  }

  public new bool IsValid => Model.IsValid(Phase.PhaseNum);

  public string? Validity
  {
    get
    {
      if (Model.IsValid(Phase.PhaseNum))
        return "valid";
      else
        return "invalid";
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

  public string? ErrorMsg => Model.Errors?.FirstOrDefault(item => item.Item1 == Phase.PhaseNum).Item2;

  [DataGridColumn(ResourceDataTemplateKey = "TypeInfoLinkTemplate",
    SortMemberPath = "Type.Name", ClipboardContentPath = "Type.Name")]
  public TypeInfoViewModel? Type
  {
    get
    {
      var thisType = this.Model;
      if (thisType != null)
      {
        if (thisType.TypeKind == TypeKind.Enum)
          return new EnumTypeInfoViewModel(Phase, thisType, TypeNameSelector);
        if (thisType.TypeKind == TypeKind.Type)
          return new TypeInfoViewModel(Phase, thisType, TypeNameSelector);
        return new ClassInfoViewModel(Phase, thisType, TypeNameSelector);
      }
      return null;
    }
  }

  public string? FullName
  {
    get
    {
      return Model.GetFullName(TypeNameSelector.Target, true, false);
    }
  }

  [DataGridColumn]
  public string? Description => Model.Description;

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
      TypeSummary.Add(new TypePropViewModel("Acceptance", new ErrString(Acceptance)));

    if (Model.IsValid(Phase.PhaseNum))
      TypeSummary.Add(new TypePropViewModel("Validation", "valid"));
    else
      TypeSummary.Add(new TypePropViewModel("Validation", new ErrString(ErrorMsg ?? "invalid")));

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
    TypeSummary.Add(new TypePropViewModel("Description", new Description(Model.Description??"")));
  }

  public async void FillDetailsAsync()
  {
    await Task.Run(() => FillDetails());
  }

  public virtual void FillDetails()
  {
  }

  /// <summary>
  /// Shown as Window.Title.
  /// </summary>
  public string Caption => TypeKind + " " + Model.GetFullName(TypeNameSelector.Target, true, false);

  public virtual object? Members => null;


  #region ShowTypeCommand
  public Command ShowTypeCommand { get; private set; }

  protected virtual bool ShowTypeCanExecute()
  {
    return Model != null;
  }

  protected virtual void ShowTypeExecute()
  {
    this.FillTypeSummaryAsync();
    this.FillDetailsAsync();
    WindowsManager.ShowWindow<TypeInfoWindow>(this);
  }
  #endregion

  #region ShowErrorCommand
  public Command ShowErrorCommand { get; private set; }

  protected virtual bool ShowErrorCanExecute()
  {
    return ErrorMsg != null;
  }

  protected virtual void ShowErrorExecute()
  {
    Phase.ShowErrorFor(this);
  }
  #endregion

}

