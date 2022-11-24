namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Explicit Relationships to Diagram Parts.
/// </summary>
public interface IRelationshipIds // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Explicit Relationship to Diagram Data Part
  /// </summary>
  public String? DataPart { get ; set; }
  
  /// <summary>
  /// Explicit Relationship to Diagram Layout Definition Part
  /// </summary>
  public String? LayoutPart { get ; set; }
  
  /// <summary>
  /// Explicit Relationship to Style Definition Part
  /// </summary>
  public String? StylePart { get ; set; }
  
  /// <summary>
  /// Explicit Relationship to Diagram Colors Part
  /// </summary>
  public String? ColorPart { get ; set; }
  
}
