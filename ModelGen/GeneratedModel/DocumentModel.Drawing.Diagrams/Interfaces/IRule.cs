namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Rule.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
public interface IRule // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Constraint Type
  /// </summary>
  public Constraint? Type { get ; set; }
  
  /// <summary>
  /// For
  /// </summary>
  public ConstraintRelationship? For { get ; set; }
  
  /// <summary>
  /// For Name
  /// </summary>
  public string? ForName { get ; set; }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public Element? PointType { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public double? Val { get ; set; }
  
  /// <summary>
  /// Factor
  /// </summary>
  public double? Fact { get ; set; }
  
  /// <summary>
  /// Max Value
  /// </summary>
  public double? Max { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
