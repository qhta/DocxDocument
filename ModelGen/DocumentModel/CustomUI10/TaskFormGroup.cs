namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the TaskFormGroup Class.
/// </summary>
public partial class TaskFormGroup: ModelElement<DXO10CUI.TaskFormGroup>
{
  public TaskFormGroup(): base(){ }
  
  public TaskFormGroup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskFormGroup(DXO10CUI.TaskFormGroup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? QualifiedId
  {
    get => HexIntConverter.GetValue(_Element?.QualifiedId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
  
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get => _Element?.IdMso;
    set => _ExistingElement.IdMso = value;
  }
  
  
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Label
  {
    get => _Element?.Label;
    set => _ExistingElement.Label = value;
  }
  
  
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get => _Element?.GetLabel;
    set => _ExistingElement.GetLabel = value;
  }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get => _Element?.GetVisible;
    set => _ExistingElement.GetVisible = value;
  }
  
  
  /// <summary>
  ///   helperText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? HelperText
  {
    get => _Element?.HelperText;
    set => _ExistingElement.HelperText = value;
  }
  
  
  /// <summary>
  ///   getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetHelperText
  {
    get => _Element?.GetHelperText;
    set => _ExistingElement.GetHelperText = value;
  }
  
  
  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowLabel
  {
    get => _Element?.ShowLabel?.Value;
    set => _ExistingElement.ShowLabel = value;
  }
  
  
  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetShowLabel
  {
    get => _Element?.GetShowLabel;
    set => _ExistingElement.GetShowLabel = value;
  }
  
}
