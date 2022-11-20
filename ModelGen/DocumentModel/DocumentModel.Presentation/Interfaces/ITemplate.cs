namespace DocumentModel.Presentation;

/// <summary>
/// Template Effects.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeNodeList))]
public interface ITemplate // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Level
  /// </summary>
  public uint? Level { get ; set; }
  
  /// <summary>
  /// Time Node List.
  /// </summary>
  public ITimeNodeList? TimeNodeList { get ; set; }
  
}
