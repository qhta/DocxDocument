namespace DocumentModel.Presentation;

/// <summary>
/// Template Effects.
/// </summary>
public interface ITemplate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Level
  /// </summary>
  public System.UInt32? Level { get ; set; }
  
  /// <summary>
  /// Time Node List.
  /// </summary>
  public DocumentModel.Presentation.ITimeNodeList? TimeNodeList { get ; set; }
  
}
