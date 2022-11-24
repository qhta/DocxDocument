namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Presentation Of.
/// </summary>
public interface IPresentationOf // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Axis
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.EnumValue<AxisValues>>? Axis { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.EnumValue<ElementValues>>? PointType { get ; set; }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.BooleanValue>? HideLastTrans { get ; set; }
  
  /// <summary>
  /// Start
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.Int32Value>? Start { get ; set; }
  
  /// <summary>
  /// Count
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.UInt32Value>? Count { get ; set; }
  
  /// <summary>
  /// Step
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.Int32Value>? Step { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
