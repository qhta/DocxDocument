namespace DocumentModel.Presentation;

/// <summary>
/// Base properties for Notes View.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IOrigin))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IScaleFactor))]
public interface ICommonViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Variable Scale
  /// </summary>
  public bool? VariableScale { get ; set; }
  
  /// <summary>
  /// View Scale.
  /// </summary>
  public IScaleFactor? ScaleFactor { get ; set; }
  
  /// <summary>
  /// View Origin.
  /// </summary>
  public IOrigin? Origin { get ; set; }
  
}
