namespace DocumentModel.Vml;

/// <summary>
/// Defines the Shadow Class.
/// </summary>
public interface IShadow // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Shadow Toggle
  /// </summary>
  public System.Boolean? On { get ; set; }
  
  /// <summary>
  /// Shadow Type
  /// </summary>
  public DocumentModel.Vml.ShadowKind? Type { get ; set; }
  
  /// <summary>
  /// Shadow Transparency
  /// </summary>
  public System.Boolean? Obscured { get ; set; }
  
  /// <summary>
  /// Shadow Primary Color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// Shadow Opacity
  /// </summary>
  public System.String? Opacity { get ; set; }
  
  /// <summary>
  /// Shadow Primary Offset
  /// </summary>
  public System.String? Offset { get ; set; }
  
  /// <summary>
  /// Shadow Secondary Color
  /// </summary>
  public System.String? Color2 { get ; set; }
  
  /// <summary>
  /// Shadow Secondary Offset
  /// </summary>
  public System.String? Offset2 { get ; set; }
  
  /// <summary>
  /// Shadow Origin
  /// </summary>
  public System.String? Origin { get ; set; }
  
  /// <summary>
  /// Shadow Perspective Matrix
  /// </summary>
  public System.String? Matrix { get ; set; }
  
}
