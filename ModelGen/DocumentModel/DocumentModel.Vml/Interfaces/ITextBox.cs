namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public interface ITextBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Shape Styling Properties
  /// </summary>
  public System.String? Style { get ; set; }
  
  /// <summary>
  /// Text Box Inset
  /// </summary>
  public System.String? Inset { get ; set; }
  
  /// <summary>
  /// Text Box Single-Click Selection Toggle
  /// </summary>
  public System.Boolean? SingleClick { get ; set; }
  
}
