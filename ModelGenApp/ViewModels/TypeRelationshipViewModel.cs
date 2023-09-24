namespace ModelGenApp.ViewModels;

public class TypeRelationshipViewModel : ViewModel<TypeRelationship>, IAcceptable
{
  public TypeRelationshipViewModel(PhaseResultsViewModel phase, TypeInfoViewModel? owner, TypeRelationship relationship, TNS nameKindSelector, bool incoming) : base(relationship)
  {
    Owner = owner;
    Phase = phase;
    NameKindSelector = nameKindSelector;
    IsIncoming = incoming;
  }

  public PhaseResultsViewModel Phase { get; private set; }

  public TypeInfoViewModel? Owner { get; private set; }

  public TNS NameKindSelector { get; private set; }

  public bool IsAccepted => Model.Target.IsAcceptedAfter(Phase.PhaseNum);

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Acceptance),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.AcceptanceTooltip)
    )]
  public Acceptance Acceptance
  {
    get
    {
      Acceptance result = 0;
      if (Model.Target.IsAcceptedAfter(Phase.PhaseNum))
        result |= Acceptance.accepted;
      if (Model.Target.IsRejectedAfter(Phase.PhaseNum))
        result |= Acceptance.rejected;
      return result;
    }
  }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Semantics)
  )]
  public string Semantics
  {
    get
    {
      return Model.Semantics.ToString().ToLower();
    }
  }

  public bool ShowFullTypeName
  {
    get => _ShowFullTypeName;
    set
    {
      if (_ShowFullTypeName != value)
      {
        _ShowFullTypeName = value;
        NotifyPropertyChanged(nameof(ShowFullTypeName));
        if (RelatedType != null)
          _RelatedType = null;
        NotifyPropertyChanged(nameof(RelatedType));
      }
    }
  }
  private bool _ShowFullTypeName;

  public bool IsIncoming { get; set; }

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.RelatedType),
    DataTemplateResourceKey = "TypeInfoLinkTemplate",
    SortMemberPath = "RelatedType.FullName",
    ClipboardContentPath = "RelatedType.FullName")]
  public TypeInfoViewModel? RelatedType
  {
    get
    {
      if (_RelatedType == null)
      {
        if (IsIncoming)
        {
          if (Model.Source != null)
            _RelatedType = TypeInfoViewModel.Create(Phase, Model.Source, NameKindSelector);
        }
        else
        {
          if (Model.Target != null)
            _RelatedType = TypeInfoViewModel.Create(Phase, Model.Target, NameKindSelector);
        }
      }
      return _RelatedType;
    }
  }
  private TypeInfoViewModel? _RelatedType;

  [DataGridColumn(
    HeaderResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.Description),
    HeaderTooltipResourceKey = "ModelGenApp.CommonStrings." + nameof(CommonStrings.DescriptionTooltip)
    )]
  public string? Description => Model.Target.Description;

}
