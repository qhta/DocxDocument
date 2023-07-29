using ModelGen;

namespace ModelGenApp.ViewModels;
public class TypeInfoViewModel : ViewModel<TypeInfo>
{
  public TypeInfoViewModel(PhaseViewModel phase, TypeInfo typeInfo, TNS typeNameSelector) : base(typeInfo)
  {
    TypeNameSelector = typeNameSelector;
    Phase = phase;
    FillTypeSummaryVM();
    ShowTypeCommand = new RelayCommand(ShowTypeExecute, ShowTypeCanExecute) { Name = "ShowTypeCommand" };
    ShowErrorCommand = new RelayCommand(ShowErrorExecute, ShowErrorCanExecute) { Name = "ShowErrorCommand" };
  }

  [DataGridColumn]
  public TypeKind TypeKind => Model.TypeKind;

  public TNS TypeNameSelector { get; private set; }

  public PhaseViewModel Phase { get; private set; }

  [DataGridColumn]
  public string? Acceptance
  {
    get
    {
      if (Model.IsAccepted)
        return "accepted";
      if (Model.IsRejected)
        return "rejected";
      return null;
    }
  }

  public string? Validity
  {
    get
    {
      if (Model.IsValid)
        return "valid";
      if (Model.IsInvalid)
        return "invalid";
      return null;
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

  public string? ErrorMsg => Model.Errors?.FirstOrDefault(item => item.Item1==Phase.Phase).Item2;

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

  public TypeSummaryViewModel TypeSummaryVM { get; } = new TypeSummaryViewModel();

  protected virtual void FillTypeSummaryVM()
  {
    TypeSummaryVM.Clear();
    TypeSummaryVM.Add(new TypePropViewModel("Acceptance", Acceptance, Model.IsRejected));
    TypeSummaryVM.Add(new TypePropViewModel("Validity", Validity, Model.IsInvalid));
    TypeSummaryVM.Add(new TypePropViewModel("Kind", TypeKind.ToString().ToLower()));
    TypeSummaryVM.Add(new TypePropViewModel("Namespace", Model.OriginalNamespace));
    TypeSummaryVM.Add(new TypePropViewModel("Name", Name));
    if (!String.IsNullOrEmpty(Model.TargetNamespace))
      TypeSummaryVM.Add(new TypePropViewModel("Target namespace", Model.TargetNamespace));
    if (!String.IsNullOrEmpty(Model.NewName))
      TypeSummaryVM.Add(new TypePropViewModel("New name", Model.NewName));
    if (Model.IsConverted)
    {
      var targetType = Model.GetConversionTarget();
      if (targetType != null)
        TypeSummaryVM.Add(new TypePropViewModel("Converted to", new TypeInfoViewModel(Phase, targetType, TypeNameSelector)));
    }
    TypeSummaryVM.Add(new TypePropViewModel("Description", Model.Description));
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
    WindowsManager.ShowWindow<TypeInfoWindow>(this);
  }
  #endregion

  #region ShowErrorCommand
  public Command ShowErrorCommand { get; private set; }

  protected virtual bool ShowErrorCanExecute()
  {
    return ErrorMsg!=null;
  }

  protected virtual void ShowErrorExecute()
  {
    Phase.ShowErrorFor(this);
  }
  #endregion

}

