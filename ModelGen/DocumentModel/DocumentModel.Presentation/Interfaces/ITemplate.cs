namespace DocumentModel.Presentation;

/// <summary>
/// Template Effects.
/// </summary>
public interface ITemplate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Level
  /// </summary>
  public UInt32? Level { get ; set; }
  
  /// <summary>
  /// Time Node List.
  /// </summary>
  public ITimeNodeList? TimeNodeList { get ; set; }
  
}
