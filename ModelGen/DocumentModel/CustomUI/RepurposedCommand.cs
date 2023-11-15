namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the RepurposedCommand Class.
/// </summary>
public partial class RepurposedCommand: ModelElement<DXOCUI.RepurposedCommand>
{
  public RepurposedCommand(): base(){ }
  
  public RepurposedCommand(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RepurposedCommand(DXOCUI.RepurposedCommand openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   onAction
  /// </summary>
  [DataMember]
  public String? OnAction
  {
    get => _Element?.OnAction;
    set => _ExistingElement.OnAction = value;
  }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get => _Element?.Enabled?.Value;
    set => _ExistingElement.Enabled = value;
  }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get => _Element?.GetEnabled;
    set => _ExistingElement.GetEnabled = value;
  }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get => _Element?.IdMso;
    set => _ExistingElement.IdMso = value;
  }
  
}
